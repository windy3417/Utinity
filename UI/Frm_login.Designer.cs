namespace Utility.UI
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.lbl_authorizer = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_certain = new System.Windows.Forms.Button();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_conect = new System.Windows.Forms.Button();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.ch_changePWD = new System.Windows.Forms.CheckBox();
            this.p_login = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.p_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_authorizer
            // 
            this.lbl_authorizer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_authorizer.AutoSize = true;
            this.lbl_authorizer.Location = new System.Drawing.Point(12, 21);
            this.lbl_authorizer.Name = "lbl_authorizer";
            this.lbl_authorizer.Size = new System.Drawing.Size(41, 12);
            this.lbl_authorizer.TabIndex = 0;
            this.lbl_authorizer.Text = "账号：";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(12, 56);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 0;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pwd.Location = new System.Drawing.Point(59, 52);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(112, 21);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.Tag = "密码";
            // 
            // btn_certain
            // 
            this.btn_certain.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_certain.Location = new System.Drawing.Point(65, 113);
            this.btn_certain.Name = "btn_certain";
            this.btn_certain.Size = new System.Drawing.Size(112, 23);
            this.btn_certain.TabIndex = 2;
            this.btn_certain.Text = "确认";
            this.btn_certain.UseVisualStyleBackColor = true;
            this.btn_certain.Click += new System.EventHandler(this.btn_certain_Click);
            // 
            // lbl_information
            // 
            this.lbl_information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_information.AutoSize = true;
            this.lbl_information.ForeColor = System.Drawing.Color.Red;
            this.lbl_information.Location = new System.Drawing.Point(15, 179);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(65, 12);
            this.lbl_information.TabIndex = 4;
            this.lbl_information.Text = "登录提醒：";
            // 
            // btn_conect
            // 
            

            this.btn_conect.Location = new System.Drawing.Point(286, 174);
            this.btn_conect.Name = "btn_conect";
            this.btn_conect.Size = new System.Drawing.Size(54, 23);
            this.btn_conect.TabIndex = 5;
            this.btn_conect.Text = "设置";
            this.btn_conect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_conect.UseVisualStyleBackColor = true;
            this.btn_conect.Click += new System.EventHandler(this.btn_conect_Click);
            // 
            // horizonLine1
            // 
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(-6, 162);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(393, 1);
            this.horizonLine1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_userID
            // 
            this.txt_userID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userID.Location = new System.Drawing.Point(59, 17);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(112, 21);
            this.txt_userID.TabIndex = 0;
            this.txt_userID.Tag = "账号";
            // 
            // ch_changePWD
            // 
            this.ch_changePWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ch_changePWD.AutoSize = true;
            this.ch_changePWD.Location = new System.Drawing.Point(177, 54);
            this.ch_changePWD.Name = "ch_changePWD";
            this.ch_changePWD.Size = new System.Drawing.Size(72, 16);
            this.ch_changePWD.TabIndex = 0;
            this.ch_changePWD.Text = "修改密码";
            this.ch_changePWD.UseVisualStyleBackColor = true;
            // 
            // p_login
            // 
            this.p_login.Controls.Add(this.ch_changePWD);
            this.p_login.Controls.Add(this.lbl_authorizer);
            this.p_login.Controls.Add(this.txt_pwd);
            this.p_login.Controls.Add(this.lbl_pwd);
            this.p_login.Controls.Add(this.txt_userID);
            this.p_login.Location = new System.Drawing.Point(64, 20);
            this.p_login.Name = "p_login";
            this.p_login.Size = new System.Drawing.Size(256, 87);
            this.p_login.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(207, 113);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 203);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p_login);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.btn_conect);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_certain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_login_KeyPress);
            this.p_login.ResumeLayout(false);
            this.p_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_authorizer;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_certain;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Button btn_conect;
        private Utility.UControl.HorizonLine horizonLine1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.CheckBox ch_changePWD;
        private System.Windows.Forms.Panel p_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}