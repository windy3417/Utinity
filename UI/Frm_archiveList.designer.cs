namespace Utility.UI
{
    partial class Frm_archiveList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_archiveList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_foot = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.gb_query = new System.Windows.Forms.GroupBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.dgv_templet = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_export = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.flp_foot.SuspendLayout();
            this.gb_query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_templet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.flp_foot);
            this.panel1.Controls.Add(this.gb_query);
            this.panel1.Controls.Add(this.dgv_templet);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(39, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 410);
            this.panel1.TabIndex = 0;
            // 
            // flp_foot
            // 
            this.flp_foot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flp_foot.Controls.Add(this.lbl_sum);
            this.flp_foot.Controls.Add(this.lbl_amount);
            this.flp_foot.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_foot.Location = new System.Drawing.Point(582, 351);
            this.flp_foot.Name = "flp_foot";
            this.flp_foot.Size = new System.Drawing.Size(338, 50);
            this.flp_foot.TabIndex = 4;
            // 
            // lbl_sum
            // 
            this.lbl_sum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_sum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_sum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sum.Location = new System.Drawing.Point(179, 0);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(156, 26);
            this.lbl_sum.TabIndex = 0;
            this.lbl_sum.Tag = "";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_amount
            // 
            this.lbl_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_amount.Location = new System.Drawing.Point(106, 6);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(67, 14);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Tag = "";
            this.lbl_amount.Text = "记录数：";
            // 
            // gb_query
            // 
            this.gb_query.Controls.Add(this.btn_query);
            this.gb_query.Location = new System.Drawing.Point(3, 57);
            this.gb_query.Name = "gb_query";
            this.gb_query.Size = new System.Drawing.Size(920, 100);
            this.gb_query.TabIndex = 3;
            this.gb_query.TabStop = false;
            this.gb_query.Text = "查询条件";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(826, 44);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.Btn_query_Click);
            // 
            // dgv_templet
            // 
            this.dgv_templet.AllowUserToAddRows = false;
            this.dgv_templet.AllowUserToDeleteRows = false;
            this.dgv_templet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_templet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_templet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_templet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_templet.Location = new System.Drawing.Point(3, 163);
            this.dgv_templet.Name = "dgv_templet";
            this.dgv_templet.ReadOnly = true;
            this.dgv_templet.RowTemplate.Height = 23;
            this.dgv_templet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_templet.Size = new System.Drawing.Size(920, 182);
            this.dgv_templet.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(414, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(98, 21);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "档案列表";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_query,
            this.tsb_delete,
            this.tsb_export,
            this.tsb_print,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(995, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_query
            // 
            this.tsb_query.Image = global::Utility.Properties.Resources.Search;
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = global::Utility.Properties.Resources.delete;
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_export
            // 
            this.tsb_export.Image = global::Utility.Properties.Resources.export;
            this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_export.Name = "tsb_export";
            this.tsb_export.Size = new System.Drawing.Size(52, 22);
            this.tsb_export.Text = "导出";
            this.tsb_export.Click += new System.EventHandler(this.tsb_export_Click);
            // 
            // tsb_print
            // 
            this.tsb_print.Image = global::Utility.Properties.Resources.打印;
            this.tsb_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_print.Name = "tsb_print";
            this.tsb_print.Size = new System.Drawing.Size(52, 22);
            this.tsb_print.Text = "打印";
            this.tsb_print.Click += new System.EventHandler(this.tsb_print_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = global::Utility.Properties.Resources.exit;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm_archiveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_archiveList";
            this.Text = "档案列表";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_weighingList_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_foot.ResumeLayout(false);
            this.flp_foot.PerformLayout();
            this.gb_query.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_templet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        protected System.Windows.Forms.Label lbl_title;
        protected System.Windows.Forms.GroupBox gb_query;
        protected System.Windows.Forms.DataGridView dgv_templet;
        protected System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;

        private System.Windows.Forms.ToolStripButton tsb_query;

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.ToolStripButton tsb_export;

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.FlowLayoutPanel flp_foot;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton tsb_print;
        private System.Windows.Forms.ToolStripButton tsb_delete;
    }
}