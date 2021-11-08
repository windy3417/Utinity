namespace Utility.UI.Authority
{
    partial class FrmAuthorization
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
            this.lbl_authorizer = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_certain = new System.Windows.Forms.Button();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.lbl_information = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_authorizer
            // 
            this.lbl_authorizer.AutoSize = true;
            this.lbl_authorizer.Location = new System.Drawing.Point(93, 38);
            this.lbl_authorizer.Name = "lbl_authorizer";
            this.lbl_authorizer.Size = new System.Drawing.Size(53, 12);
            this.lbl_authorizer.TabIndex = 1;
            this.lbl_authorizer.Text = "授权人：";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(93, 77);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 1;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(154, 73);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(119, 21);
            this.txt_pwd.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(201, 122);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_certain
            // 
            this.btn_certain.Location = new System.Drawing.Point(95, 122);
            this.btn_certain.Name = "btn_certain";
            this.btn_certain.Size = new System.Drawing.Size(75, 23);
            this.btn_certain.TabIndex = 2;
            this.btn_certain.Text = "确认";
            this.btn_certain.UseVisualStyleBackColor = true;
            this.btn_certain.Click += new System.EventHandler(this.btn_certain_Click);
            // 
            // cmb_user
            // 
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Location = new System.Drawing.Point(152, 34);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(121, 20);
            this.cmb_user.TabIndex = 3;
            // 
            // lbl_information
            // 
            this.lbl_information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_information.AutoSize = true;
            this.lbl_information.ForeColor = System.Drawing.Color.Red;
            this.lbl_information.Location = new System.Drawing.Point(12, 198);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(0, 12);
            this.lbl_information.TabIndex = 4;
            // 
            // Frm_authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 265);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.cmb_user);
            this.Controls.Add(this.btn_certain);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_authorizer);
            this.Controls.Add(this.txt_pwd);
            this.Name = "Frm_authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "业务授权";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_authorizer;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_certain;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.Label lbl_information;
    }
}