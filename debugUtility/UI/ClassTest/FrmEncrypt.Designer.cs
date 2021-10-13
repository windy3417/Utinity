
namespace DebugUtility.UI.ClassTest
{
    partial class FrmEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEncrypt));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSha1 = new System.Windows.Forms.ToolStripButton();
            this.rtbEncrypted = new System.Windows.Forms.RichTextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSha1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSha1
            // 
            this.tsbSha1.Image = ((System.Drawing.Image)(resources.GetObject("tsbSha1.Image")));
            this.tsbSha1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSha1.Name = "tsbSha1";
            this.tsbSha1.Size = new System.Drawing.Size(59, 22);
            this.tsbSha1.Text = "SHA1";
            this.tsbSha1.Click += new System.EventHandler(this.tsbSha1_Click);
            // 
            // rtbEncrypted
            // 
            this.rtbEncrypted.Location = new System.Drawing.Point(12, 200);
            this.rtbEncrypted.Name = "rtbEncrypted";
            this.rtbEncrypted.Size = new System.Drawing.Size(776, 96);
            this.rtbEncrypted.TabIndex = 2;
            this.rtbEncrypted.Text = "";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 75);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(776, 96);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "原文：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密文：";
            // 
            // FrmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.rtbEncrypted);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEncrypt";
            this.Text = "FrmEncrypt";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSha1;
        private System.Windows.Forms.RichTextBox rtbEncrypted;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}