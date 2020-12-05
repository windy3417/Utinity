namespace Utility.UI
{
    partial class Frm_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_config));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
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
            this.label_user = new System.Windows.Forms.Label();
            this.button_testConect = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.gb_status.SuspendLayout();
            this.gb_dateBaseConete.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.gb_status.Controls.Add(this.btn_deleteDateConfig);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.lbl_configStatus);
            this.gb_status.Location = new System.Drawing.Point(609, 54);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(224, 174);
            this.gb_status.TabIndex = 19;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "配置状态";
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_close.Location = new System.Drawing.Point(18, 141);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "关闭窗体";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_deleteDateConfig
            // 
            this.btn_deleteDateConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteDateConfig.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDateConfig.Image")));
            this.btn_deleteDateConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteDateConfig.Location = new System.Drawing.Point(18, 91);
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
            this.lbl_status.Location = new System.Drawing.Point(18, 63);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 12);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "未配置";
            // 
            // lbl_configStatus
            // 
            this.lbl_configStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_configStatus.AutoSize = true;
            this.lbl_configStatus.Location = new System.Drawing.Point(18, 33);
            this.lbl_configStatus.Name = "lbl_configStatus";
            this.lbl_configStatus.Size = new System.Drawing.Size(95, 12);
            this.lbl_configStatus.TabIndex = 8;
            this.lbl_configStatus.Text = "数据库配置状态:";
            // 
            // gb_dateBaseConete
            // 
            this.gb_dateBaseConete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_dateBaseConete.Controls.Add(this.tableLayoutPanel2);
            this.gb_dateBaseConete.Location = new System.Drawing.Point(139, 54);
            this.gb_dateBaseConete.Name = "gb_dateBaseConete";
            this.gb_dateBaseConete.Size = new System.Drawing.Size(451, 174);
            this.gb_dateBaseConete.TabIndex = 18;
            this.gb_dateBaseConete.TabStop = false;
            this.gb_dateBaseConete.Text = "业务数据库连接";
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
            this.tableLayoutPanel2.Controls.Add(this.label_user, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_testConect, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_confirm, 2, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 19);
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
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(3, 61);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(47, 12);
            this.label_user.TabIndex = 9;
            this.label_user.Text = "用户名:";
            // 
            // button_testConect
            // 
            this.button_testConect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_testConect.Location = new System.Drawing.Point(93, 114);
            this.button_testConect.Name = "button_testConect";
            this.button_testConect.Size = new System.Drawing.Size(66, 23);
            this.button_testConect.TabIndex = 5;
            this.button_testConect.Text = "测试连接";
            this.button_testConect.UseVisualStyleBackColor = true;
            this.button_testConect.Click += new System.EventHandler(this.button_testConect_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_confirm.Location = new System.Drawing.Point(227, 114);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(66, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // Frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 419);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_dateBaseConete);
            this.Name = "Frm_config";
            this.Text = "数据库配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_config_FormClosed);
            this.Load += new System.EventHandler(this.Frm_config_Load);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_dateBaseConete.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Button btn_close;
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
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button button_testConect;
        private System.Windows.Forms.Button button_confirm;
    }
}