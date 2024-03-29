﻿namespace Utility.UI
{
    partial class FrmLoginConfigDB

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginConfigDB));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.btnBusinessSave = new System.Windows.Forms.Button();
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.btn_adminCertain = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_adminCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adminName = new System.Windows.Forms.TextBox();
            this.txt_adminPwd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnectTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_plugDataBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_admin.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btn_deletePlugConfig);
            this.groupBox1.Controls.Add(this.lbl_plugStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 80);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置状态";
            // 
            // btn_deletePlugConfig
            // 
            this.btn_deletePlugConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deletePlugConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletePlugConfig.Image")));
            this.btn_deletePlugConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletePlugConfig.Location = new System.Drawing.Point(24, 42);
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
            this.lbl_plugStatus.Location = new System.Drawing.Point(123, 22);
            this.lbl_plugStatus.Name = "lbl_plugStatus";
            this.lbl_plugStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_plugStatus.TabIndex = 8;
            this.lbl_plugStatus.Text = "未配置";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "数据库配置状态:";
            // 
            // gb_plugDataBase
            // 
            this.gb_plugDataBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_plugDataBase.Controls.Add(this.tableLayoutPanel1);
            this.gb_plugDataBase.Location = new System.Drawing.Point(31, 14);
            this.gb_plugDataBase.Name = "gb_plugDataBase";
            this.gb_plugDataBase.Size = new System.Drawing.Size(282, 174);
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
            this.tableLayoutPanel1.Controls.Add(this.btnBusinessSave, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 143);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // txt_plugPWD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugPWD, 2);
            this.txt_plugPWD.Location = new System.Drawing.Point(62, 84);
            this.txt_plugPWD.Name = "txt_plugPWD";
            this.txt_plugPWD.PasswordChar = '*';
            this.txt_plugPWD.Size = new System.Drawing.Size(147, 21);
            this.txt_plugPWD.TabIndex = 4;
            // 
            // txt_plugUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugUser, 2);
            this.txt_plugUser.Location = new System.Drawing.Point(62, 57);
            this.txt_plugUser.Name = "txt_plugUser";
            this.txt_plugUser.Size = new System.Drawing.Size(147, 21);
            this.txt_plugUser.TabIndex = 3;
            // 
            // txt_plugDataBase
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugDataBase, 2);
            this.txt_plugDataBase.Location = new System.Drawing.Point(62, 30);
            this.txt_plugDataBase.Name = "txt_plugDataBase";
            this.txt_plugDataBase.Size = new System.Drawing.Size(147, 21);
            this.txt_plugDataBase.TabIndex = 2;
            // 
            // txt_plugServer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_plugServer, 2);
            this.txt_plugServer.Location = new System.Drawing.Point(62, 3);
            this.txt_plugServer.Name = "txt_plugServer";
            this.txt_plugServer.Size = new System.Drawing.Size(147, 21);
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
            this.btn_plugConcet.Location = new System.Drawing.Point(64, 114);
            this.btn_plugConcet.Name = "btn_plugConcet";
            this.btn_plugConcet.Size = new System.Drawing.Size(66, 23);
            this.btn_plugConcet.TabIndex = 5;
            this.btn_plugConcet.Text = "测试连接";
            this.btn_plugConcet.UseVisualStyleBackColor = true;
            this.btn_plugConcet.Click += new System.EventHandler(this.btnConnectTest_Click);
            // 
            // btnBusinessSave
            // 
            this.btnBusinessSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusinessSave.Location = new System.Drawing.Point(140, 114);
            this.btnBusinessSave.Name = "btnBusinessSave";
            this.btnBusinessSave.Size = new System.Drawing.Size(66, 23);
            this.btnBusinessSave.TabIndex = 6;
            this.btnBusinessSave.Text = "确认";
            this.btnBusinessSave.UseVisualStyleBackColor = true;
            this.btnBusinessSave.Click += new System.EventHandler(this.btnBusinessSave_Click);
            // 
            // gb_admin
            // 
            this.gb_admin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_admin.Controls.Add(this.btn_adminCertain);
            this.gb_admin.Controls.Add(this.tableLayoutPanel3);
            this.gb_admin.Location = new System.Drawing.Point(31, 306);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(591, 100);
            this.gb_admin.TabIndex = 22;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "管理员密码设定";
            // 
            // btn_adminCertain
            // 
            this.btn_adminCertain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adminCertain.Location = new System.Drawing.Point(267, 69);
            this.btn_adminCertain.Name = "btn_adminCertain";
            this.btn_adminCertain.Size = new System.Drawing.Size(66, 23);
            this.btn_adminCertain.TabIndex = 6;
            this.btn_adminCertain.Text = "确认";
            this.btn_adminCertain.UseVisualStyleBackColor = true;
            this.btn_adminCertain.Click += new System.EventHandler(this.btn_adminCertain_Click);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txt_adminCode
            // 
            this.txt_adminCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminCode.Location = new System.Drawing.Point(87, 6);
            this.txt_adminCode.Name = "txt_adminCode";
            this.txt_adminCode.Size = new System.Drawing.Size(83, 21);
            this.txt_adminCode.TabIndex = 4;
            this.txt_adminCode.Text = "admin";
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
            this.label3.Location = new System.Drawing.Point(187, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            // 
            // txt_adminName
            // 
            this.txt_adminName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminName.Location = new System.Drawing.Point(257, 6);
            this.txt_adminName.Multiline = true;
            this.txt_adminName.Name = "txt_adminName";
            this.txt_adminName.Size = new System.Drawing.Size(97, 21);
            this.txt_adminName.TabIndex = 4;
            this.txt_adminName.Text = "admin";
            // 
            // txt_adminPwd
            // 
            this.txt_adminPwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_adminPwd.Location = new System.Drawing.Point(428, 6);
            this.txt_adminPwd.Name = "txt_adminPwd";
            this.txt_adminPwd.PasswordChar = '*';
            this.txt_adminPwd.Size = new System.Drawing.Size(110, 21);
            this.txt_adminPwd.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(340, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 174);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "外挂数据库连接";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtPwd, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtUser, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtServer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnConnectTest, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 143);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // txtPwd
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtPwd, 2);
            this.txtPwd.Location = new System.Drawing.Point(62, 84);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(147, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // txtUser
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtUser, 2);
            this.txtUser.Location = new System.Drawing.Point(62, 57);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(147, 21);
            this.txtUser.TabIndex = 3;
            // 
            // txtDB
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDB, 2);
            this.txtDB.Location = new System.Drawing.Point(62, 30);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(147, 21);
            this.txtDB.TabIndex = 2;
            // 
            // txtServer
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtServer, 2);
            this.txtServer.Location = new System.Drawing.Point(62, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(147, 21);
            this.txtServer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据库:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "服务器：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "密码:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "用户名:";
            // 
            // btnConnectTest
            // 
            this.btnConnectTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnectTest.Location = new System.Drawing.Point(64, 114);
            this.btnConnectTest.Name = "btnConnectTest";
            this.btnConnectTest.Size = new System.Drawing.Size(66, 23);
            this.btnConnectTest.TabIndex = 5;
            this.btnConnectTest.Text = "测试连接";
            this.btnConnectTest.UseVisualStyleBackColor = true;
            this.btnConnectTest.Click += new System.EventHandler(this.btn_plugConcet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(140, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "确认";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnPlugStringSave_Click);
            // 
            // FrmLoginConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_plugDataBase);
            this.Controls.Add(this.gb_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginConfigDB";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.Frm_DoubleDataBaseConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_plugDataBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_admin.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.Button btnBusinessSave;
        private System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txt_adminCode;
        protected System.Windows.Forms.TextBox txt_adminName;
        protected System.Windows.Forms.TextBox txt_adminPwd;
        internal System.Windows.Forms.Button btn_adminCertain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnectTest;
        private System.Windows.Forms.Button btnSave;
    }
}