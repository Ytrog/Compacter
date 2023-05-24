namespace Compacter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAnalyze = new ToolStripButton();
            tsbCompress = new ToolStripButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, toolStripSeparator1, tsbAnalyze, tsbCompress });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(257, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tsbOpen
            // 
            tsbOpen.Image = (Image)resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(92, 22);
            tsbOpen.Text = "Open Folder";
            tsbOpen.ToolTipText = "Open Folder";
            tsbOpen.Click += tsbOpen_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbAnalyze
            // 
            tsbAnalyze.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAnalyze.Enabled = false;
            tsbAnalyze.Image = (Image)resources.GetObject("tsbAnalyze.Image");
            tsbAnalyze.ImageTransparentColor = Color.Magenta;
            tsbAnalyze.Name = "tsbAnalyze";
            tsbAnalyze.Size = new Size(52, 22);
            tsbAnalyze.Text = "Analyze";
            tsbAnalyze.Click += tsbAnalyze_Click;
            // 
            // tsbCompress
            // 
            tsbCompress.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbCompress.Enabled = false;
            tsbCompress.Image = (Image)resources.GetObject("tsbCompress.Image");
            tsbCompress.ImageTransparentColor = Color.Magenta;
            tsbCompress.Name = "tsbCompress";
            tsbCompress.Size = new Size(64, 22);
            tsbCompress.Text = "Compress";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "Main";
            Text = "Compacter";
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAnalyze;
        private ToolStripButton tsbCompress;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}