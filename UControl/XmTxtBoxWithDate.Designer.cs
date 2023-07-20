namespace Utility.UControl
{
    partial class XmTxtBoxWithDate
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
            this.txt_withDate = new System.Windows.Forms.TextBox();
            this.dtp_inTextBox = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_withDate
            // 
            this.txt_withDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_withDate.Location = new System.Drawing.Point(0, 0);
            this.txt_withDate.Name = "txt_withDate";
            this.txt_withDate.Size = new System.Drawing.Size(169, 21);
            this.txt_withDate.TabIndex = 0;
            this.txt_withDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_withDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_withDate_MouseDown);
            // 
            // dtp_inTextBox
            // 
            this.dtp_inTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtp_inTextBox.Location = new System.Drawing.Point(149, 0);
            this.dtp_inTextBox.Name = "dtp_inTextBox";
            this.dtp_inTextBox.RightToLeftLayout = true;
            this.dtp_inTextBox.Size = new System.Drawing.Size(20, 21);
            this.dtp_inTextBox.TabIndex = 1;
            this.dtp_inTextBox.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(9, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(13, 12);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // txtBoxWithDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dtp_inTextBox);
            this.Controls.Add(this.txt_withDate);
            this.Name = "txtBoxWithDate";
            this.Size = new System.Drawing.Size(169, 21);
            this.Enter += new System.EventHandler(this.TxtBoxWithDate_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_withDate;
        private System.Windows.Forms.DateTimePicker dtp_inTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
