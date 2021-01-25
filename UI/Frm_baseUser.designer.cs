namespace Utility.UI
{
    partial class Frm_baseUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_baseUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_voucherStatus = new System.Windows.Forms.Label();
            this.dgv_person = new System.Windows.Forms.DataGridView();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_regitrationDate = new System.Windows.Forms.Label();
            this.tbd_effect = new Utility.UControl.txtBoxWithDate();
            this.label4 = new System.Windows.Forms.Label();
            this.tbd_failure = new Utility.UControl.txtBoxWithDate();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failuerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_person)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.lbl_voucherStatus);
            this.panel1.Controls.Add(this.dgv_person);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 410);
            this.panel1.TabIndex = 0;
            // 
            // lbl_voucherStatus
            // 
            this.lbl_voucherStatus.AutoSize = true;
            this.lbl_voucherStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_voucherStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_voucherStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_voucherStatus.Location = new System.Drawing.Point(642, 4);
            this.lbl_voucherStatus.Name = "lbl_voucherStatus";
            this.lbl_voucherStatus.Size = new System.Drawing.Size(72, 14);
            this.lbl_voucherStatus.TabIndex = 3;
            this.lbl_voucherStatus.Text = "档案状态：";
            // 
            // dgv_person
            // 
            this.dgv_person.AllowUserToAddRows = false;
            this.dgv_person.AllowUserToDeleteRows = false;
            this.dgv_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_person.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.Name,
            this.loginPWD,
            this.registrationDate,
            this.failuerDate});
            this.dgv_person.Location = new System.Drawing.Point(3, 241);
            this.dgv_person.Name = "dgv_person";
            this.dgv_person.ReadOnly = true;
            this.dgv_person.RowTemplate.Height = 23;
            this.dgv_person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_person.Size = new System.Drawing.Size(738, 150);
            this.dgv_person.TabIndex = 2;
            this.dgv_person.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_person.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(337, 32);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(134, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "人 员 档 案";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_userID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_userName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_regitrationDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbd_effect, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbd_failure, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_pwd, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "人员名称标签";
            this.label1.Text = "人员姓名:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Tag = "人员编码标签";
            this.label2.Text = "人员编码：";
            // 
            // txt_userID
            // 
            this.txt_userID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userID.Location = new System.Drawing.Point(111, 9);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(252, 21);
            this.txt_userID.TabIndex = 1;
            this.txt_userID.Tag = "客户编码";
            this.txt_userID.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // txt_userName
            // 
            this.txt_userName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userName.Location = new System.Drawing.Point(111, 49);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(252, 21);
            this.txt_userName.TabIndex = 2;
            this.txt_userName.Tag = "客户名称";
            // 
            // lbl_regitrationDate
            // 
            this.lbl_regitrationDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_regitrationDate.AutoSize = true;
            this.lbl_regitrationDate.Location = new System.Drawing.Point(381, 14);
            this.lbl_regitrationDate.Name = "lbl_regitrationDate";
            this.lbl_regitrationDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_regitrationDate.TabIndex = 0;
            this.lbl_regitrationDate.Tag = "注册日期标签";
            this.lbl_regitrationDate.Text = "注册日期：";
            // 
            // tbd_effect
            // 
            this.tbd_effect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbd_effect.Location = new System.Drawing.Point(477, 9);
            this.tbd_effect.Name = "tbd_effect";
            this.tbd_effect.Size = new System.Drawing.Size(252, 21);
            this.tbd_effect.TabIndex = 3;
            this.tbd_effect.Tag = "生效日期";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Tag = "注销日期标签";
            this.label4.Text = "注销日期：";
            // 
            // tbd_failure
            // 
            this.tbd_failure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbd_failure.Location = new System.Drawing.Point(477, 49);
            this.tbd_failure.Name = "tbd_failure";
            this.tbd_failure.Size = new System.Drawing.Size(252, 21);
            this.tbd_failure.TabIndex = 3;
            this.tbd_failure.Tag = "失效日期";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Tag = "登录密码标签";
            this.label5.Text = "登录密码:";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pwd.Location = new System.Drawing.Point(111, 90);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(252, 21);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Tag = "登录密码";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_abandon,
            this.tsb_save,
            this.tsb_modify,
            this.tsb_query,
            this.tsb_delete,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(52, 22);
            this.tsb_add.Text = "增加";
            this.tsb_add.Click += new System.EventHandler(this.Tsb_add_Click);
            // 
            // tsb_abandon
            // 
            this.tsb_abandon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abandon.Image")));
            this.tsb_abandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abandon.Name = "tsb_abandon";
            this.tsb_abandon.Size = new System.Drawing.Size(52, 22);
            this.tsb_abandon.Text = "放弃";
            this.tsb_abandon.Click += new System.EventHandler(this.Tsb_abandon_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.Tsb_save_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(52, 22);
            this.tsb_modify.Text = "修改";
            this.tsb_modify.Click += new System.EventHandler(this.Tsb_modify_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userID.DataPropertyName = "userID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.userID.DefaultCellStyle = dataGridViewCellStyle2;
            this.userID.FillWeight = 50.76142F;
            this.userID.Frozen = true;
            this.userID.HeaderText = "人员编码";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 149.2386F;
            this.Name.HeaderText = "人员姓名";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // loginPWD
            // 
            this.loginPWD.DataPropertyName = "pwd";
            this.loginPWD.HeaderText = "登录密码";
            this.loginPWD.Name = "loginPWD";
            this.loginPWD.ReadOnly = true;
            // 
            // registrationDate
            // 
            this.registrationDate.DataPropertyName = "RegistrationDate";
            this.registrationDate.HeaderText = "注册日期";
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.ReadOnly = true;
            // 
            // failuerDate
            // 
            this.failuerDate.DataPropertyName = "failuerDate";
            this.failuerDate.HeaderText = "注销日期";
            this.failuerDate.Name = "failuerDate";
            this.failuerDate.ReadOnly = true;
            // 
            // Frm_baseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            //this.Name = "Frm_baseUser";
            this.Text = "人员档案";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_customer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_customer_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_person)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        protected System.Windows.Forms.Label lbl_customer;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
      
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_regitrationDate;
        private System.Windows.Forms.Label label4;
       
        private System.Windows.Forms.ToolStripButton tsb_add;
       
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_abandon;

        protected System.Windows.Forms.Label lbl_voucherStatus;
        private System.Windows.Forms.Label label5;


        protected System.Windows.Forms.TextBox txt_userID;
        protected System.Windows.Forms.TextBox txt_userName;
        protected System.Windows.Forms.TextBox txt_pwd;
        protected Utility.UControl.txtBoxWithDate tbd_effect;
        protected Utility.UControl.txtBoxWithDate tbd_failure;

        protected System.Windows.Forms.DataGridView dgv_person;

        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginPWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn failuerDate;
    }
}