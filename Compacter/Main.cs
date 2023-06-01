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
            if (folderManager != null && folderManager.Initialized && folderManager.FileItems != null)
            {
                folderManager.Analyze();
                FillDataSource(folderManager.FileItems, true);
            }
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
                row.Analyzed = analyzed;
                row.Packed = file.Packed;
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
            Compressor.Compress(this);
            folderManager.Analyze();
            FillDataSource(folderManager.FileItems, true);
        }
    }
}