using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

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
                InitFolderManager(folderBrowserDialog1.SelectedPath);
            }
        }

        private void InitFolderManager(string path)
        {
            folderManager = new() { Path = path };
            StatusFolder.Text = path;
            folderManager.Init();
            if (IsInitialized(folderManager)) // this ensures foldermanager and its FileItems are not null
            {
                SetEnabledStatus();
                tsbParallel.Checked = folderManager.FileItems.Count > 15;
                FillDataSource(folderManager.FileItems);
            }
            else
            {
                SetEnabledStatus();
                throw new Exception($"{folderManager.Path} could not be enumerated");
            }
        }

        /// <summary>
        /// Set the enabled status of buttons
        /// </summary>
        private void SetEnabledStatus()
        {
            tsbAnalyze.Enabled = IsInitialized(folderManager);
            tsbCompress.Enabled = IsAnalyzed;
        }

        /// <summary>
        /// Determine if <paramref name="fm"/> is initialized
        /// </summary>
        /// <param name="fm"></param>
        /// <returns></returns>
        private bool IsInitialized([NotNullWhen(true)] FolderManager? fm)
        {
            return fm is not null && fm.Initialized && fm.FileItems is not null;
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
                    SetEnabledStatus();
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
                    row.RowError = file.ErrorMessage;
                }
                else
                {
                    row.ClearErrors();
                }

                table.Rows.Add(row);
            }

            UpdateAmount();
        }

        private void UpdateAmount()
        {
            StatusAmount.Text = $"Amount: {resultBindingSource.Count}";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Environment.IsPrivilegedProcess)
            {
                this.Text = $"{this.Text} – Administator";
            }

            resultBindingSource.DataSource = new AnalysisResult.ResultDataTable();
        }

        private void tsbCompress_Click(object sender, EventArgs e)
        {
            if (folderManager == null || !folderManager.Analyzed)
            {
                MessageBox.Show(this, "Please analyze the folder first", "Not Analyzed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SetEnabledStatus();
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
            SetEnabledStatus();

            if (compressed)
            {
                Analyze();
            }
        }

        private void tsbShowCompressible_CheckedChanged(object sender, EventArgs e)
        {
            FilterTable(tsbShowCompressible.Checked);
        }

        private void FilterTable(bool onlyCompressible)
        {
            if (IsAnalyzed)
            {
                if (onlyCompressible)
                {
                    resultBindingSource.Filter = "analyzed = true AND packed = false AND compressed = false";
                }
                else
                {
                    resultBindingSource.RemoveFilter();
                }
            }

            UpdateAmount();
        }

        private bool IsAnalyzed => folderManager != null && folderManager.Analyzed;
    }
}