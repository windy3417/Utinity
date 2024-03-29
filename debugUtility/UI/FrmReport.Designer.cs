﻿namespace DebugUtility.UI
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_export = new System.Windows.Forms.ToolStripButton();
            this.tsb_exportDgv = new System.Windows.Forms.ToolStripButton();
            this.tsb_exportCsv = new System.Windows.Forms.ToolStripButton();
            this.tsbRowSpan = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test1,
            this.test2,
            this.test3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // test1
            // 
            this.test1.HeaderText = "test1";
            this.test1.Name = "test1";
            this.test1.ReadOnly = true;
            // 
            // test2
            // 
            this.test2.HeaderText = "test2";
            this.test2.Name = "test2";
            this.test2.ReadOnly = true;
            // 
            // test3
            // 
            this.test3.HeaderText = "test3";
            this.test3.Name = "test3";
            this.test3.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_query,
            this.tsb_export,
            this.tsb_exportDgv,
            this.tsb_exportCsv,
            this.tsbRowSpan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_query
            // 
            this.tsb_query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(37, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.Tsb_query_Click);
            // 
            // tsb_export
            // 
            this.tsb_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_export.Image = ((System.Drawing.Image)(resources.GetObject("tsb_export.Image")));
            this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_export.Name = "tsb_export";
            this.tsb_export.Size = new System.Drawing.Size(37, 22);
            this.tsb_export.Text = "导出";
            this.tsb_export.Click += new System.EventHandler(this.Tsb_export_Click);
            // 
            // tsb_exportDgv
            // 
            this.tsb_exportDgv.Image = global::DebugUtility.Properties.Resources.export;
            this.tsb_exportDgv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exportDgv.Name = "tsb_exportDgv";
            this.tsb_exportDgv.Size = new System.Drawing.Size(79, 22);
            this.tsb_exportDgv.Text = "导出表格";
            this.tsb_exportDgv.Click += new System.EventHandler(this.tsb_exportDgv_Click);
            // 
            // tsb_exportCsv
            // 
            this.tsb_exportCsv.Image = global::DebugUtility.Properties.Resources.export;
            this.tsb_exportCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exportCsv.Name = "tsb_exportCsv";
            this.tsb_exportCsv.Size = new System.Drawing.Size(74, 22);
            this.tsb_exportCsv.Text = "导出CSV";
            this.tsb_exportCsv.Click += new System.EventHandler(this.tsb_exportCsv_Click);
            // 
            // tsbRowSpan
            // 
            this.tsbRowSpan.Image = ((System.Drawing.Image)(resources.GetObject("tsbRowSpan.Image")));
            this.tsbRowSpan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRowSpan.Name = "tsbRowSpan";
            this.tsbRowSpan.Size = new System.Drawing.Size(79, 22);
            this.tsbRowSpan.Text = "多层表头";
            this.tsbRowSpan.Click += new System.EventHandler(this.tsbRowSpan_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmReport";
            this.Text = "测试报表";
            this.Load += new System.EventHandler(this.Frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_export;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_exportDgv;
        private System.Windows.Forms.ToolStripButton tsb_exportCsv;
        private System.Windows.Forms.ToolStripButton tsbRowSpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn test1;
        private System.Windows.Forms.DataGridViewTextBoxColumn test2;
        private System.Windows.Forms.DataGridViewTextBoxColumn test3;
    }
}