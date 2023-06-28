using System.ComponentModel;

namespace Compacter
{
    public partial class Main : Form
    {

        private FolderManager? folderManager;

        public Main()
        {
            InitializeComponent();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                folderManager = new() { Path = folderBrowserDialog1.SelectedPath };
                StatusFolder.Text = folderBrowserDialog1.SelectedPath;
                folderManager.Init();
                if (folderManager.Initialized && folderManager.FileItems != null)
                {
                    SetEnabledStatus(true);
                    FillDataSource(folderManager.FileItems);
                }
                else
                {
                    SetEnabledStatus(false);
                    throw new Exception($"{folderManager.Path} could not be enumerated");
                }
            }
        }

        private void SetEnabledStatus(bool enable)
        {
            tsbAnalyze.Enabled = enable;
            tsbCompress.Enabled = enable;
        }

        private void tsbAnalyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }

        private void Analyze()
        {
            if (folderManager != null && folderManager.Initialized && folderManager.FileItems != null)
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += (o, e) =>
                {
                    folderManager.Analyze(tsbParallel.Checked);
                };
                worker.RunWorkerCompleted += (o, e) =>
                {
                    FillDataSource(folderManager.FileItems, true);
                    MarkBusy(false); // disable
                };
                MarkBusy(true);
                worker.RunWorkerAsync();
            }
        }

        private void MarkBusy(bool busy)
        {
            if (busy)
            {
                tsProgress.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                tsProgress.Style = ProgressBarStyle.Continuous;

            }
            Application.UseWaitCursor = busy;
            dgvAnalysisResult.Cursor = this.Cursor; // otherwise the cursor will remain the wait cursor
        }

        private void FillDataSource(IEnumerable<FileItem> files, bool analyzed = false)
        {
            AnalysisResult.ResultDataTable table = (AnalysisResult.ResultDataTable)resultBindingSource.DataSource;
            table.Rows.Clear();
            foreach (FileItem file in files)
            {
                var row = table.NewResultRow();
                row.Compressed = file.Compressed;
                row.Entropy = file.Entropy;
                row.SizeOnDisk = file.SizeOnDisk;
                row.Path = file.Path;
                row.Analyzed = file.Analyzed;
                row.Packed = file.Packed;
                row.ErrorOccurred = file.ErrorOccurred;

                if (row.ErrorOccurred)
                {
                    row.RowError = "File could not be opened";
                }
                else 
                {
                    row.ClearErrors(); 
                }

                table.Rows.Add(row);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            resultBindingSource.DataSource = new AnalysisResult.ResultDataTable();
        }

        private void tsbCompress_Click(object sender, EventArgs e)
        {
            if (folderManager == null || !folderManager.Analyzed) // TODO just disable button?
            {
                MessageBox.Show(this, "Please analyze the folder first", "Not Analyzed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SetEnabledStatus(false);
                Compressor compressor = new Compressor(folderManager);
                compressor.ScriptCreated += Compressor_ScriptCreated;
                compressor.CreateScript();
            }
        }

        private void Compressor_ScriptCreated(object? sender, string e)
        {
            if (folderManager == null || folderManager.FileItems == null)
            {
                throw new InvalidOperationException("folderManager is null or in an invalid state");
            }
            bool compressed = Compressor.Compress(this);
            SetEnabledStatus(true);

            if (compressed)
            {
                Analyze(); 
            }
        }
    }
}