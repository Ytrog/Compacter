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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            StatusFolder = new ToolStripStatusLabel();
            tsProgress = new ToolStripProgressBar();
            dgvAnalysisResult = new DataGridView();
            Analyzed = new DataGridViewCheckBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeOnDiskDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            entropyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Packed = new DataGridViewCheckBoxColumn();
            compressedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            resultBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAnalyze = new ToolStripButton();
            tsbCompress = new ToolStripButton();
            tsbParallel = new ToolStripButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnalysisResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dgvAnalysisResult);
            toolStripContainer1.ContentPanel.Size = new Size(800, 403);
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
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusFolder, tsProgress });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            // 
            // StatusFolder
            // 
            StatusFolder.Name = "StatusFolder";
            StatusFolder.Size = new Size(113, 17);
            StatusFolder.Text = "Please open a folder";
            // 
            // tsProgress
            // 
            tsProgress.Name = "tsProgress";
            tsProgress.Size = new Size(100, 16);
            // 
            // dgvAnalysisResult
            // 
            dgvAnalysisResult.AllowUserToAddRows = false;
            dgvAnalysisResult.AllowUserToDeleteRows = false;
            dgvAnalysisResult.AutoGenerateColumns = false;
            dgvAnalysisResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnalysisResult.Columns.AddRange(new DataGridViewColumn[] { Analyzed, pathDataGridViewTextBoxColumn, sizeOnDiskDataGridViewTextBoxColumn, entropyDataGridViewTextBoxColumn, Packed, compressedDataGridViewCheckBoxColumn });
            dgvAnalysisResult.DataSource = resultBindingSource;
            dgvAnalysisResult.Dock = DockStyle.Fill;
            dgvAnalysisResult.Location = new Point(0, 0);
            dgvAnalysisResult.Name = "dgvAnalysisResult";
            dgvAnalysisResult.ReadOnly = true;
            dgvAnalysisResult.RowTemplate.Height = 25;
            dgvAnalysisResult.Size = new Size(800, 403);
            dgvAnalysisResult.TabIndex = 0;
            // 
            // Analyzed
            // 
            Analyzed.DataPropertyName = "Analyzed";
            Analyzed.HeaderText = "Analyzed";
            Analyzed.Name = "Analyzed";
            Analyzed.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeOnDiskDataGridViewTextBoxColumn
            // 
            sizeOnDiskDataGridViewTextBoxColumn.DataPropertyName = "SizeOnDisk";
            sizeOnDiskDataGridViewTextBoxColumn.HeaderText = "SizeOnDisk";
            sizeOnDiskDataGridViewTextBoxColumn.Name = "sizeOnDiskDataGridViewTextBoxColumn";
            sizeOnDiskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entropyDataGridViewTextBoxColumn
            // 
            entropyDataGridViewTextBoxColumn.DataPropertyName = "Entropy";
            entropyDataGridViewTextBoxColumn.HeaderText = "Entropy";
            entropyDataGridViewTextBoxColumn.Name = "entropyDataGridViewTextBoxColumn";
            entropyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Packed
            // 
            Packed.DataPropertyName = "Packed";
            Packed.HeaderText = "Packed";
            Packed.Name = "Packed";
            Packed.ReadOnly = true;
            // 
            // compressedDataGridViewCheckBoxColumn
            // 
            compressedDataGridViewCheckBoxColumn.DataPropertyName = "Compressed";
            compressedDataGridViewCheckBoxColumn.HeaderText = "Compressed";
            compressedDataGridViewCheckBoxColumn.Name = "compressedDataGridViewCheckBoxColumn";
            compressedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // resultBindingSource
            // 
            resultBindingSource.DataMember = "Result";
            resultBindingSource.DataSource = typeof(AnalysisResult);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, toolStripSeparator1, tsbAnalyze, tsbCompress, tsbParallel });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(328, 25);
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
            tsbCompress.Click += tsbCompress_Click;
            // 
            // tsbParallel
            // 
            tsbParallel.BackColor = SystemColors.Control;
            tsbParallel.CheckOnClick = true;
            tsbParallel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbParallel.Image = (Image)resources.GetObject("tsbParallel.Image");
            tsbParallel.ImageTransparentColor = Color.Magenta;
            tsbParallel.Name = "tsbParallel";
            tsbParallel.Size = new Size(71, 22);
            tsbParallel.Text = "Use parallel";
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
            Load += Main_Load;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnalysisResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).EndInit();
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
        private DataGridView dgvAnalysisResult;
        private BindingSource resultBindingSource;
        private DataGridViewCheckBoxColumn Analyzed;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeOnDiskDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entropyDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Packed;
        private DataGridViewCheckBoxColumn compressedDataGridViewCheckBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusFolder;
        private ToolStripProgressBar tsProgress;
        private ToolStripButton tsbParallel;
    }
}