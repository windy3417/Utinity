namespace Utility.UControl
{
    partial class DbConnectControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtDataBase = new System.Windows.Forms.TextBox();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.lbl_plugDataBase = new System.Windows.Forms.Label();
            this.lbl_plugServer = new System.Windows.Forms.Label();
            this.lbl_plugPWD = new System.Windows.Forms.Label();
            this.lbl_plugUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TxtPWD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtDataBase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugDataBase, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugServer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugPWD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plugUser, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 111);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // TxtPWD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtPWD, 2);
            this.TxtPWD.Location = new System.Drawing.Point(62, 84);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(158, 21);
            this.TxtPWD.TabIndex = 4;
            // 
            // TxtUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtUser, 2);
            this.TxtUser.Location = new System.Drawing.Point(62, 57);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(158, 21);
            this.TxtUser.TabIndex = 3;
            // 
            // TxtDataBase
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtDataBase, 2);
            this.TxtDataBase.Location = new System.Drawing.Point(62, 30);
            this.TxtDataBase.Name = "TxtDataBase";
            this.TxtDataBase.Size = new System.Drawing.Size(158, 21);
            this.TxtDataBase.TabIndex = 2;
            // 
            // TxtServer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtServer, 2);
            this.TxtServer.Location = new System.Drawing.Point(62, 3);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(158, 21);
            this.TxtServer.TabIndex = 1;
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
            this.lbl_plugPWD.Location = new System.Drawing.Point(3, 90);
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
            // DbConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DbConnectControl";
            this.Size = new System.Drawing.Size(268, 157);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox TxtPWD;
        public System.Windows.Forms.TextBox TxtUser;
        public System.Windows.Forms.TextBox TxtDataBase;
        public System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.Label lbl_plugDataBase;
        private System.Windows.Forms.Label lbl_plugServer;
        private System.Windows.Forms.Label lbl_plugPWD;
        private System.Windows.Forms.Label lbl_plugUser;
    }
}
