namespace debugUtility.UI.ClassTest
{
    partial class FrmSMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMB));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExplore = new System.Windows.Forms.ToolStripButton();
            this.tsbDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbRead = new System.Windows.Forms.ToolStripButton();
            this.tsbUpload = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tsbReadExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExplore,
            this.tsbDownload,
            this.tsbRead,
            this.tsbUpload,
            this.tsbReadExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExplore
            // 
            this.tsbExplore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExplore.Image = ((System.Drawing.Image)(resources.GetObject("tsbExplore.Image")));
            this.tsbExplore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExplore.Name = "tsbExplore";
            this.tsbExplore.Size = new System.Drawing.Size(36, 22);
            this.tsbExplore.Text = "浏览";
            this.tsbExplore.Click += new System.EventHandler(this.tsbExplore_Click);
            // 
            // tsbDownload
            // 
            this.tsbDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsbDownload.Image")));
            this.tsbDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDownload.Name = "tsbDownload";
            this.tsbDownload.Size = new System.Drawing.Size(52, 22);
            this.tsbDownload.Text = "下载";
            this.tsbDownload.Click += new System.EventHandler(this.tsbDownload_Click);
            // 
            // tsbRead
            // 
            this.tsbRead.Image = ((System.Drawing.Image)(resources.GetObject("tsbRead.Image")));
            this.tsbRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRead.Name = "tsbRead";
            this.tsbRead.Size = new System.Drawing.Size(55, 22);
            this.tsbRead.Text = "read";
            this.tsbRead.Click += new System.EventHandler(this.tsbRead_Click);
            // 
            // tsbUpload
            // 
            this.tsbUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpload.Image")));
            this.tsbUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpload.Name = "tsbUpload";
            this.tsbUpload.Size = new System.Drawing.Size(52, 22);
            this.tsbUpload.Text = "上传";
            this.tsbUpload.Click += new System.EventHandler(this.tsbUpload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tsbReadExcel
            // 
            this.tsbReadExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReadExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbReadExcel.Image")));
            this.tsbReadExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReadExcel.Name = "tsbReadExcel";
            this.tsbReadExcel.Size = new System.Drawing.Size(41, 22);
            this.tsbReadExcel.Text = "excel";
            this.tsbReadExcel.Click += new System.EventHandler(this.tsbReadExcel_Click);
            // 
            // FrmSMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmSMB";
            this.Text = "FrmSMB";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExplore;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton tsbDownload;
        private System.Windows.Forms.ToolStripButton tsbRead;
        private System.Windows.Forms.ToolStripButton tsbUpload;
        private System.Windows.Forms.ToolStripButton tsbReadExcel;
    }
}