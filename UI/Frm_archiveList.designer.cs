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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_incomeDateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_incomeDateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmb_custName = new System.Windows.Forms.ComboBox();
            this.dgv_templet = new System.Windows.Forms.DataGridView();
            this.lbl_customer = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_templet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.flp_foot);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgv_templet);
            this.panel1.Controls.Add(this.lbl_customer);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.54127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.98398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.65823F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_incomeDateStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_incomeDateEnd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_custName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Tag = "客户编码标签";
            this.label2.Text = "客户编码：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Tag = "过磅日期标签";
            this.label3.Text = "过磅日期：";
            // 
            // dtp_incomeDateStart
            // 
            this.dtp_incomeDateStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_incomeDateStart.Location = new System.Drawing.Point(84, 45);
            this.dtp_incomeDateStart.Name = "dtp_incomeDateStart";
            this.dtp_incomeDateStart.Size = new System.Drawing.Size(198, 21);
            this.dtp_incomeDateStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "到";
            // 
            // dtp_incomeDateEnd
            // 
            this.dtp_incomeDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_incomeDateEnd.Location = new System.Drawing.Point(313, 45);
            this.dtp_incomeDateEnd.Name = "dtp_incomeDateEnd";
            this.dtp_incomeDateEnd.Size = new System.Drawing.Size(198, 21);
            this.dtp_incomeDateEnd.TabIndex = 2;
            // 
            // cmb_custName
            // 
            this.cmb_custName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_custName.FormattingEnabled = true;
            this.cmb_custName.Location = new System.Drawing.Point(84, 8);
            this.cmb_custName.Name = "cmb_custName";
            this.cmb_custName.Size = new System.Drawing.Size(198, 20);
            this.cmb_custName.TabIndex = 3;
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
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(414, 22);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(164, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "过磅结算单列表";
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
            this.Text = "过磅结算单列表";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_weighingList_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_foot.ResumeLayout(false);
            this.flp_foot.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_templet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label label3;

        protected System.Windows.Forms.DataGridView dgv_templet;

        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DateTimePicker dtp_incomeDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_incomeDateEnd;
        private System.Windows.Forms.ComboBox cmb_custName;
        private System.Windows.Forms.ToolStripButton tsb_export;

        protected System.Windows.Forms.Label lbl_sum;

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.FlowLayoutPanel flp_foot;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton tsb_print;
        private System.Windows.Forms.ToolStripButton tsb_delete;
    }
}