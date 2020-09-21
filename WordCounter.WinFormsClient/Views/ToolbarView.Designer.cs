namespace WordCounter.WinFormsClient.Views
{
    partial class ToolbarView
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.ButtonRun = new System.Windows.Forms.ToolStripButton();
            this.ButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.ButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonOpenFile,
            this.ButtonRun,
            this.ButtonInfo,
            this.ButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 97);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonOpenFile.Image = global::WordCounter.WinFormsClient.Properties.Resources.open_file;
            this.ButtonOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(100, 94);
            this.ButtonOpenFile.Text = "toolStripButton1";
            // 
            // ButtonRun
            // 
            this.ButtonRun.AutoSize = false;
            this.ButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonRun.Image = global::WordCounter.WinFormsClient.Properties.Resources.run;
            this.ButtonRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(96, 96);
            this.ButtonRun.Text = "toolStripButton2";
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.AutoSize = false;
            this.ButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonInfo.Image = global::WordCounter.WinFormsClient.Properties.Resources.info;
            this.ButtonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(96, 96);
            this.ButtonInfo.Text = "toolStripButton3";
            // 
            // ButtonExit
            // 
            this.ButtonExit.AutoSize = false;
            this.ButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonExit.Image = global::WordCounter.WinFormsClient.Properties.Resources.exit;
            this.ButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(96, 96);
            this.ButtonExit.Text = "toolStripButton4";
            // 
            // ToolbarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 97);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolbarView";
            this.Text = "ToolbarView";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonOpenFile;
        private System.Windows.Forms.ToolStripButton ButtonRun;
        private System.Windows.Forms.ToolStripButton ButtonInfo;
        private System.Windows.Forms.ToolStripButton ButtonExit;
    }
}