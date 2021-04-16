namespace debugUtility.UI
{
    partial class FrmDataGridViewExtention
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
            this.dgvExtention = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtention)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExtention
            // 
            this.dgvExtention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtention.Location = new System.Drawing.Point(12, 40);
            this.dgvExtention.Name = "dgvExtention";
            this.dgvExtention.RowTemplate.Height = 23;
            this.dgvExtention.Size = new System.Drawing.Size(776, 398);
            this.dgvExtention.TabIndex = 0;
            // 
            // FrmDataGridViewExtention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvExtention);
            this.Name = "FrmDataGridViewExtention";
            this.Text = "FrmDataGridViewExtention";
            this.Load += new System.EventHandler(this.FrmDataGridViewExtention_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtention)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExtention;
    }
}