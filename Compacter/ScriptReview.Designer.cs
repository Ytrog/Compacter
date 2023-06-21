namespace Compacter
{
    partial class ScriptReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptReview));
            flowLayoutPanel1 = new FlowLayoutPanel();
            rtbBanner = new RichTextBox();
            tbScript = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnYes = new Button();
            btnNo = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rtbBanner);
            flowLayoutPanel1.Controls.Add(tbScript);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 537);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // rtbBanner
            // 
            rtbBanner.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rtbBanner.Location = new Point(3, 3);
            rtbBanner.Multiline = false;
            rtbBanner.Name = "rtbBanner";
            rtbBanner.ReadOnly = true;
            rtbBanner.ScrollBars = RichTextBoxScrollBars.Horizontal;
            rtbBanner.Size = new Size(800, 39);
            rtbBanner.TabIndex = 0;
            rtbBanner.Text = "Does this look right?";
            // 
            // tbScript
            // 
            tbScript.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbScript.Location = new Point(3, 48);
            tbScript.Multiline = true;
            tbScript.Name = "tbScript";
            tbScript.ReadOnly = true;
            tbScript.ScrollBars = ScrollBars.Both;
            tbScript.Size = new Size(800, 354);
            tbScript.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnYes);
            flowLayoutPanel2.Controls.Add(btnNo);
            flowLayoutPanel2.Location = new Point(3, 408);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 122);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnYes
            // 
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.Location = new Point(3, 3);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.DialogResult = DialogResult.No;
            btnNo.Location = new Point(84, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // ScriptReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScriptReview";
            Text = "Review Script";
            Load += ScriptReview_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox rtbBanner;
        private TextBox tbScript;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnYes;
        private Button btnNo;
    }
}