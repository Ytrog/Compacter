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
                if (folderManager.Initialized)
                {
                    SetEnabledStatus(true);
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
            if (folderManager != null && folderManager.Initialized)
            {
                folderManager.Analyze();
            }
        }
    }
}