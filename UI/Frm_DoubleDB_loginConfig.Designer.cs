namespace Utility.UI
{
    partial class Frm_DoubleDB_loginConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoubleDB_loginConfig));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.btn_deleteDateConfig = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_configStatus = new System.Windows.Forms.Label();
            this.gb_dateBaseConete = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.label_database = new System.Windows.Forms.Label();
            this.label_server = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_testConect = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deletePlugConfig = new System.Windows.Forms.Button();
            this.lbl_plugStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_plugDataBase = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_plugPWD = new System.Windows.Forms.TextBox();
            this.txt_plugUser = new System.Windows.Forms.TextBox();
            this.txt_plugDataBase = new System.Windows.Forms.TextBox();
            this.txt_plugServer = new System.Windows.Forms.TextBox();
            this.lbl_plugDataBase = new System.Windows.Forms.Label();
            this.lbl_plugServer = new System.Windows.Forms.Label();
            this.lbl_plugPWD = new System.Windows.Forms.Label();
            this.lbl_plugUser = new System.Windows.Forms.Label();
            this.btn_plugConcet = new System.Windows.Forms.Button();
            this.btn_plugCertain = new System.Windows.Forms.Button();
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adminCode = new System.Windows.Forms.TextBox();
            this.txt_adminName = new System.Windows.Forms.TextBox();
            this.txt_adminPwd = new System.Windows.Forms.TextBox();
            this.btn_adminCertain = new System.Windows.Forms.Button();
            this.gb_status.SuspendLayout();
            this.gb_dateBaseConete.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_plugDataBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_admin.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gb_status
            // 
            this.gb_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_status.Controls.Add(this.btn_deleteDateConfig);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.lbl_configStatus);
            this.gb_status.Location = new System.Drawing.Point(22, 206);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(254, 51);
            this.gb_status.TabIndex = 19;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "U8配置状态";
            // 
            // btn_deleteDateConfig
            // 
            this.btn_deleteDateConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteDateConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDateConfig.Image")));
            this.btn_deleteDateConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteDateConfig.Location = new System.Drawing.Point(173, 17);
            this.btn_deleteDateConfig.Name = "btn_deleteDateConfig";
            this.btn_deleteDateConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteDateConfig.TabIndex = 9;
            this.btn_deleteDateConfig.Text = "删除配置";
            this.btn_deleteDateConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteDateConfig.UseVisualStyleBackColor = true;
            this.btn_deleteDateConfig.Click += new System.EventHandler(this.Btn_deleteDateConfig_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(107, 22);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 12);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "未配置";
            // 
            // lbl_configStatus
            // 
            this.lbl_configStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_configStatus.AutoSize = true;
            this.lbl_configStatus.Location = new System.Drawing.Point(6, 22);
            this.lbl_configStatus.Name = "lbl_configStatus";
            this.lbl_configStatus.Size = new System.Drawing.Size(95, 12);
            this.lbl_configStatus.TabIndex = 8;
            this.lbl_configStatus.Text = "数据库配置状态:";
            // 
            // gb_dateBaseConete
            // 
            this.gb_dateBaseConete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_dateBaseConete.Controls.Add(this.tableLayoutPanel2);
            this.gb_dateBaseConete.Location = new System.Drawing.Point(22, 14);
            this.gb_dateBaseConete.Name = "gb_dateBaseConete";
            this.gb_dateBaseConete.Size = new System.Drawing.Size(254, 174);
            this.gb_dateBaseConete.TabIndex = 18;
            this.gb_dateBaseConete.TabStop = false;
            this.gb_dateBaseConete.Text = "U8数据库连接";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_user, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_database, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_server, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_database, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_server, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_password, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_user, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_testConect, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_confirm, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox_password, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 143);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(62, 84);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(175, 21);
            this.textBox_password.TabIndex = 4;
            // 
            // textBox_user
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_user, 2);
            this.textBox_user.Location = new System.Drawing.Point(62, 57);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(175, 21);
            this.textBox_user.TabIndex = 3;
            // 
            // textBox_database
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_database, 2);
            this.textBox_database.Location = new System.Drawing.Point(62, 30);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(175, 21);
            this.textBox_database.TabIndex = 2;
            // 
            // textBox_server
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_server, 2);
            this.textBox_server.Location = new System.Drawing.Point(62, 3);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(175, 21);
            this.textBox_server.TabIndex = 1;
            // 
            // label_database
            // 
            this.label_database.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_database.AutoSize = true;
            this.label_database.Location = new System.Drawing.Point(3, 34);
            this.label_database.Name = "label_database";
            this.label_database.Size = new System.Drawing.Size(47, 12);
            this.label_database.TabIndex = 10;
            this.label_database.Text = "数据库:";
            // 
            // label_server
            // 
            this.label_server.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_server.AutoSize = true;
            this.label_server.Location = new System.Drawing.Point(3, 7);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(53, 12);
            this.label_server.TabIndex = 11;
            this.label_server.Text = "服务器：";
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(3, 88);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(35, 12);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "密码:";
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(3, 61);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(47, 12);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "用户名:";
            // 
            // btn_testConect
            // 
            this.btn_testConect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_testConect.Location = new System.Drawing.Point(71, 114);
            this.btn_testConect.Name = "btn_testConect";
            this.btn_testConect.Size = new System.Drawing.Size(66, 23);
            this.btn_testConect.TabIndex = 5;
            this.btn_testConect.Text = "测试连接";
            this.btn_testConect.UseVisualStyleBackColor = true;
            this.btn_testConect.Click += new System.EventHandler(this.button_testConect_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_confirm.Location = new System.Drawing.Point(161, 114);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(66, 23);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btn_deletePlugConfig);
            this.groupBox1.Controls.Add(this.lbl_plugStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(296, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 51);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "外挂配置状态";
            // 
            // btn_deletePlugConfig
            // 
            this.btn_deletePlugConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deletePlugConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletePlugConfig.Image")));
            this.btn_deletePlugConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletePlugConfig.Location = new System.Drawing.Point(168, 18);
            this.btn_deletePlugConfig.Name = "btn_deletePlugConfig";
            this.btn_deletePlugConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_deletePlugConfig.TabIndex = 9;
            this.btn_deletePlugConfig.Text = "删除配置";
            this.btn_deletePlugConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletePlugConfig.UseVisualStyleBackColor = true;
            this.btn_deletePlugConfig.Click += new System.EventHandler(this.btn_deletePlugConfig_Click);
            // 
            // lbl_plugStatus
            // 
            this.lbl_plugStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_plugStatus.AutoSize = true;
            this.lbl_plugStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_plugStatus.Location = new System.Drawing.Point(102, 23);
            this.lbl_plugStatus.Name = "lbl_plugStatus";
            this.lbl_plugStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_plugStatus.TabIndex = 8;
            this.lbl_plugStatus.Text = "未配置";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "数据库配置状态:";
            // 
            // gb_plugDataBase
            // 
            this.gb_plugDataBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_plugDataBase.Controls.Add(this.tableLayoutPanel1);
            this.gb_plugDataBase.Location = new System.Drawing.Point(296, 14);
            this.gb_plugDataBase.Name = "gb_plugDataBase";
            this.gb_plugDataBase.Size = new System.Drawing.Size(254, 174);
            this.gb_plugDataBase.TabIndex = 20;
            this.gb_plugDataBase.TabStop = false;
            this.gb_plugDataBase.Text = "外挂数据库连接";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_plugPWD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_plugUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_plugDataBase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_plugServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugDataBase, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugServer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugPWD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_plugConcet, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_plugCertain, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 143);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // txt_plugPWD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugPWD, 2);
            this.txt_plugPWD.Location = new System.Drawing.Point(62, 84);
            this.txt_plugPWD.Name = "txt_plugPWD";
            this.txt_plugPWD.PasswordChar = '*';
            this.txt_plugPWD.Size = new System.Drawing.Size(170, 21);
            this.txt_plugPWD.TabIndex = 4;
            // 
            // txt_plugUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugUser, 2);
            this.txt_plugUser.Location = new System.Drawing.Point(62, 57);
            this.txt_plugUser.Name = "txt_plugUser";
            this.txt_plugUser.Size = new System.Drawing.Size(170, 21);
            this.txt_plugUser.TabIndex = 3;
            // 
            // txt_plugDataBase
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugDataBase, 2);
            this.txt_plugDataBase.Location = new System.Drawing.Point(62, 30);
            this.txt_plugDataBase.Name = "txt_plugDataBase";
            this.txt_plugDataBase.Size = new System.Drawing.Size(170, 21);
            this.txt_plugDataBase.TabIndex = 2;
            // 
            // txt_plugServer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugServer, 2);
            this.txt_plugServer.Location = new System.Drawing.Point(62, 3);
            this.txt_plugServer.Name = "txt_plugServer";
            this.txt_plugServer.Size = new System.Drawing.Size(170, 21);
            this.txt_plugServer.TabIndex = 1;
            // 
            // lbl_plugDataBase
            // 
            this.lbl_plugDataBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_plugDataBase.AutoSize = true;
            this.lbl_plugDataBase.Location = new System.Drawing.Point(3, 34);
            this.lbl_plugDataBase.Name = "lbl_plugDataBase";
            this.lbl_plugDataBase.Size = new System.Drawing.Size(47, 12);
            this.lbl_plugDataBase.TabIndex = 10;
            this.lbl_plugDataBase.Text = "数据库:";
            // 
            // lbl_plugServer
            // 
            this.lbl_plugServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_plugServer.AutoSize = true;
            this.lbl_plugServer.Location = new System.Drawing.Point(3, 7);
            this.lbl_plugServer.Name = "lbl_plugServer";
            this.lbl_plugServer.Size = new System.Drawing.Size(53, 12);
            this.lbl_plugServer.TabIndex = 11;
            this.lbl_plugServer.Text = "服务器：";
            // 
            // lbl_plugPWD
            // 
            this.lbl_plugPWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_plugPWD.AutoSize = true;
            this.lbl_plugPWD.Location = new System.Drawing.Point(3, 88);
            this.lbl_plugPWD.Name = "lbl_plugPWD";
            this.lbl_plugPWD.Size = new System.Drawing.Size(35, 12);
            this.lbl_plugPWD.TabIndex = 8;
            this.lbl_plugPWD.Text = "密码:";
            // 
            // lbl_plugUser
            // 
            this.lbl_plugUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_plugUser.AutoSize = true;
            this.lbl_plugUser.Location = new System.Drawing.Point(3, 61);
            this.lbl_plugUser.Name = "lbl_plugUser";
            this.lbl_plugUser.Size = new System.Drawing.Size(47, 12);
            this.lbl_plugUser.TabIndex = 9;
            this.lbl_plugUser.Text = "用户名:";
            // 
            // btn_plugConcet
            // 
            this.btn_plugConcet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_plugConcet.Location = new System.Drawing.Point(70, 114);
            this.btn_plugConcet.Name = "btn_plugConcet";
            this.btn_plugConcet.Size = new System.Drawing.Size(66, 23);
            this.btn_plugConcet.TabIndex = 5;
            this.btn_plugConcet.Text = "测试连接";
            this.btn_plugConcet.UseVisualStyleBackColor = true;
            this.btn_plugConcet.Click += new System.EventHandler(this.btn_plugConcet_Click);
            // 
            // btn_plugCertain
            // 
            this.btn_plugCertain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_plugCertain.Location = new System.Drawing.Point(158, 114);
            this.btn_plugCertain.Name = "btn_plugCertain";
            this.btn_plugCertain.Size = new System.Drawing.Size(66, 23);
            this.btn_plugCertain.TabIndex = 6;
            this.btn_plugCertain.Text = "确认";
            this.btn_plugCertain.UseVisualStyleBackColor = true;
            this.btn_plugCertain.Click += new System.EventHandler(this.btn_plugCertain_Click);
            // 
            // gb_admin
            // 
            this.gb_admin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_admin.Controls.Add(this.tableLayoutPanel3);
            this.gb_admin.Controls.Add(this.btn_adminCertain);
            this.gb_admin.Location = new System.Drawing.Point(22, 274);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(528, 95);
            this.gb_admin.TabIndex = 22;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "管理员密码设定";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.97006F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.76447F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57485F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55888F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.98004F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75249F));
            this.tableLayoutPanel3.Controls.Add(this.txt_adminCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_adminName, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_adminPwd, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(501, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编码：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            // 
            // txt_adminCode
            // 
            this.txt_adminCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminCode.Location = new System.Drawing.Point(78, 6);
            this.txt_adminCode.Name = "txt_adminCode";
            this.txt_adminCode.Size = new System.Drawing.Size(83, 21);
            this.txt_adminCode.TabIndex = 4;
            // 
            // txt_adminName
            // 
            this.txt_adminName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminName.Location = new System.Drawing.Point(230, 6);
            this.txt_adminName.Name = "txt_adminName";
            this.txt_adminName.Size = new System.Drawing.Size(97, 21);
            this.txt_adminName.TabIndex = 4;
            // 
            // txt_adminPwd
            // 
            this.txt_adminPwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminPwd.Location = new System.Drawing.Point(383, 6);
            this.txt_adminPwd.Name = "txt_adminPwd";
            this.txt_adminPwd.PasswordChar = '*';
            this.txt_adminPwd.Size = new System.Drawing.Size(110, 21);
            this.txt_adminPwd.TabIndex = 4;
            // 
            // btn_adminCertain
            // 
            this.btn_adminCertain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adminCertain.Location = new System.Drawing.Point(205, 66);
            this.btn_adminCertain.Name = "btn_adminCertain";
            this.btn_adminCertain.Size = new System.Drawing.Size(66, 23);
            this.btn_adminCertain.TabIndex = 6;
            this.btn_adminCertain.Text = "确认";
            this.btn_adminCertain.UseVisualStyleBackColor = true;
            this.btn_adminCertain.Click += new System.EventHandler(this.btn_adminCertain_Click);
            // 
            // Frm_DoubleDB_loginConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.gb_admin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_plugDataBase);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_dateBaseConete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DoubleDB_loginConfig";
            this.Text = "登录双数据库配置";
            this.Load += new System.EventHandler(this.Frm_DoubleDataBaseConfig_Load);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_dateBaseConete.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_plugDataBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_admin.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Button btn_deleteDateConfig;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_configStatus;
        private System.Windows.Forms.GroupBox gb_dateBaseConete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label_database;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_testConect;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deletePlugConfig;
        private System.Windows.Forms.Label lbl_plugStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_plugDataBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_plugPWD;
        private System.Windows.Forms.TextBox txt_plugUser;
        private System.Windows.Forms.TextBox txt_plugDataBase;
        private System.Windows.Forms.TextBox txt_plugServer;
        private System.Windows.Forms.Label lbl_plugDataBase;
        private System.Windows.Forms.Label lbl_plugServer;
        private System.Windows.Forms.Label lbl_plugPWD;
        private System.Windows.Forms.Label lbl_plugUser;
        private System.Windows.Forms.Button btn_plugConcet;
        private System.Windows.Forms.Button btn_plugCertain;
        private System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txt_adminCode;
        protected System.Windows.Forms.TextBox txt_adminName;
        protected System.Windows.Forms.TextBox txt_adminPwd;
        private System.Windows.Forms.Button btn_adminCertain;
    }
}