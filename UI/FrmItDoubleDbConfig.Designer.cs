namespace Utility.UI
{
    partial class FrmItDoubleDbConfig

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItDoubleDbConfig));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_deleteItDateConfig = new System.Windows.Forms.Button();
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
            this.btn_closePlug = new System.Windows.Forms.Button();
            this.btn_deleteBusinessConfig = new System.Windows.Forms.Button();
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
            this.gb_status.SuspendLayout();
            this.gb_dateBaseConete.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_plugDataBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.gb_status.Controls.Add(this.btn_close);
            this.gb_status.Controls.Add(this.btn_deleteItDateConfig);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.lbl_configStatus);
            this.gb_status.Location = new System.Drawing.Point(441, 19);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(150, 174);
            this.gb_status.TabIndex = 19;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "配置状态";
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_close.Location = new System.Drawing.Point(29, 133);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "关闭窗体";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_deleteItDateConfig
            // 
            this.btn_deleteItDateConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteItDateConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteItDateConfig.Image")));
            this.btn_deleteItDateConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteItDateConfig.Location = new System.Drawing.Point(29, 91);
            this.btn_deleteItDateConfig.Name = "btn_deleteItDateConfig";
            this.btn_deleteItDateConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItDateConfig.TabIndex = 9;
            this.btn_deleteItDateConfig.Text = "删除配置";
            this.btn_deleteItDateConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteItDateConfig.UseVisualStyleBackColor = true;
            this.btn_deleteItDateConfig.Click += new System.EventHandler(this.button_deleteItConfig_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(29, 63);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 12);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "未配置";
            // 
            // lbl_configStatus
            // 
            this.lbl_configStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_configStatus.AutoSize = true;
            this.lbl_configStatus.Location = new System.Drawing.Point(29, 31);
            this.lbl_configStatus.Name = "lbl_configStatus";
            this.lbl_configStatus.Size = new System.Drawing.Size(95, 12);
            this.lbl_configStatus.TabIndex = 8;
            this.lbl_configStatus.Text = "数据库配置状态:";
            // 
            // gb_dateBaseConete
            // 
            this.gb_dateBaseConete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_dateBaseConete.Controls.Add(this.tableLayoutPanel2);
            this.gb_dateBaseConete.Location = new System.Drawing.Point(28, 19);
            this.gb_dateBaseConete.Name = "gb_dateBaseConete";
            this.gb_dateBaseConete.Size = new System.Drawing.Size(382, 174);
            this.gb_dateBaseConete.TabIndex = 18;
            this.gb_dateBaseConete.TabStop = false;
            this.gb_dateBaseConete.Text = "运维数据库连接";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_password, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox_user, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_database, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_server, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_database, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_server, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_password, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_user, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_testConect, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_confirm, 2, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 143);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // textBox_password
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_password, 2);
            this.textBox_password.Location = new System.Drawing.Point(62, 84);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(263, 21);
            this.textBox_password.TabIndex = 4;
            // 
            // textBox_user
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_user, 2);
            this.textBox_user.Location = new System.Drawing.Point(62, 57);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(263, 21);
            this.textBox_user.TabIndex = 3;
            // 
            // textBox_database
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_database, 2);
            this.textBox_database.Location = new System.Drawing.Point(62, 30);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(263, 21);
            this.textBox_database.TabIndex = 2;
            // 
            // textBox_server
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_server, 2);
            this.textBox_server.Location = new System.Drawing.Point(62, 3);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(263, 21);
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
            this.btn_testConect.Location = new System.Drawing.Point(93, 114);
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
            this.btn_confirm.Location = new System.Drawing.Point(227, 114);
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
            this.groupBox1.Controls.Add(this.btn_closePlug);
            this.groupBox1.Controls.Add(this.btn_deleteBusinessConfig);
            this.groupBox1.Controls.Add(this.lbl_plugStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(435, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 174);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置状态";
            // 
            // btn_closePlug
            // 
            this.btn_closePlug.Image = ((System.Drawing.Image)(resources.GetObject("btn_closePlug.Image")));
            this.btn_closePlug.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_closePlug.Location = new System.Drawing.Point(29, 133);
            this.btn_closePlug.Name = "btn_closePlug";
            this.btn_closePlug.Size = new System.Drawing.Size(75, 23);
            this.btn_closePlug.TabIndex = 10;
            this.btn_closePlug.Text = "关闭窗体";
            this.btn_closePlug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_closePlug.UseVisualStyleBackColor = true;
            this.btn_closePlug.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_deleteBusinessConfig
            // 
            this.btn_deleteBusinessConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteBusinessConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteBusinessConfig.Image")));
            this.btn_deleteBusinessConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteBusinessConfig.Location = new System.Drawing.Point(29, 96);
            this.btn_deleteBusinessConfig.Name = "btn_deleteBusinessConfig";
            this.btn_deleteBusinessConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteBusinessConfig.TabIndex = 9;
            this.btn_deleteBusinessConfig.Text = "删除配置";
            this.btn_deleteBusinessConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteBusinessConfig.UseVisualStyleBackColor = true;
            this.btn_deleteBusinessConfig.Click += new System.EventHandler(this.btn_deletePlugConfig_Click);
            // 
            // lbl_plugStatus
            // 
            this.lbl_plugStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_plugStatus.AutoSize = true;
            this.lbl_plugStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_plugStatus.Location = new System.Drawing.Point(29, 58);
            this.lbl_plugStatus.Name = "lbl_plugStatus";
            this.lbl_plugStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_plugStatus.TabIndex = 8;
            this.lbl_plugStatus.Text = "未配置";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "数据库配置状态:";
            // 
            // gb_plugDataBase
            // 
            this.gb_plugDataBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_plugDataBase.Controls.Add(this.tableLayoutPanel1);
            this.gb_plugDataBase.Location = new System.Drawing.Point(28, 208);
            this.gb_plugDataBase.Name = "gb_plugDataBase";
            this.gb_plugDataBase.Size = new System.Drawing.Size(388, 174);
            this.gb_plugDataBase.TabIndex = 20;
            this.gb_plugDataBase.TabStop = false;
            this.gb_plugDataBase.Text = "业务数据库连接";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 143);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // txt_plugPWD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugPWD, 2);
            this.txt_plugPWD.Location = new System.Drawing.Point(62, 84);
            this.txt_plugPWD.Name = "txt_plugPWD";
            this.txt_plugPWD.PasswordChar = '*';
            this.txt_plugPWD.Size = new System.Drawing.Size(263, 21);
            this.txt_plugPWD.TabIndex = 4;
            // 
            // txt_plugUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugUser, 2);
            this.txt_plugUser.Location = new System.Drawing.Point(62, 57);
            this.txt_plugUser.Name = "txt_plugUser";
            this.txt_plugUser.Size = new System.Drawing.Size(263, 21);
            this.txt_plugUser.TabIndex = 3;
            // 
            // txt_plugDataBase
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugDataBase, 2);
            this.txt_plugDataBase.Location = new System.Drawing.Point(62, 30);
            this.txt_plugDataBase.Name = "txt_plugDataBase";
            this.txt_plugDataBase.Size = new System.Drawing.Size(263, 21);
            this.txt_plugDataBase.TabIndex = 2;
            // 
            // txt_plugServer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugServer, 2);
            this.txt_plugServer.Location = new System.Drawing.Point(62, 3);
            this.txt_plugServer.Name = "txt_plugServer";
            this.txt_plugServer.Size = new System.Drawing.Size(263, 21);
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
            this.btn_plugConcet.Location = new System.Drawing.Point(93, 114);
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
            this.btn_plugCertain.Location = new System.Drawing.Point(227, 114);
            this.btn_plugCertain.Name = "btn_plugCertain";
            this.btn_plugCertain.Size = new System.Drawing.Size(66, 23);
            this.btn_plugCertain.TabIndex = 6;
            this.btn_plugCertain.Text = "确认";
            this.btn_plugCertain.UseVisualStyleBackColor = true;
            this.btn_plugCertain.Click += new System.EventHandler(this.btnSaveBusinessConnetiongString_Click);
            // 
            // FrmItDoubleDbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_plugDataBase);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_dateBaseConete);
            this.Name = "FrmItDoubleDbConfig";
            this.Text = "双数据库配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_config_FormClosed);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_deleteItDateConfig;
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
        private System.Windows.Forms.Button btn_closePlug;
        private System.Windows.Forms.Button btn_deleteBusinessConfig;
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
    }
}