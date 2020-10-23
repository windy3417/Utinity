namespace DebugUtility
{
    partial class Frm_child
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxWithDatePicker2 = new Utility.UControl.txtBoxWithDate();
            this.txtBoxWithDatePicker1 = new Utility.UControl.txtBoxWithDate();
            this.userControl11 = new Utility.UControl.txtBoxWithDate();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_mendDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(133, 153);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(452, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // txtBoxWithDatePicker2
            // 
            this.txtBoxWithDatePicker2.Location = new System.Drawing.Point(502, 51);
            this.txtBoxWithDatePicker2.Name = "txtBoxWithDatePicker2";
            this.txtBoxWithDatePicker2.Size = new System.Drawing.Size(219, 21);
            this.txtBoxWithDatePicker2.TabIndex = 4;
            // 
            // txtBoxWithDatePicker1
            // 
            this.txtBoxWithDatePicker1.Location = new System.Drawing.Point(418, 120);
            this.txtBoxWithDatePicker1.Name = "txtBoxWithDatePicker1";
            this.txtBoxWithDatePicker1.Size = new System.Drawing.Size(125, 21);
            this.txtBoxWithDatePicker1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(563, 357);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(169, 21);
            this.userControl11.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_mendDate
            // 
            this.txt_mendDate.Location = new System.Drawing.Point(291, 32);
            this.txt_mendDate.Name = "txt_mendDate";
            this.txt_mendDate.Size = new System.Drawing.Size(100, 21);
            this.txt_mendDate.TabIndex = 7;
            // 
            // Frm_child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mendDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.txtBoxWithDatePicker2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxWithDatePicker1);
            this.Name = "Frm_child";
            this.Text = "子窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.UControl.txtBoxWithDate txtBoxWithDatePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Utility.UControl.txtBoxWithDate txtBoxWithDatePicker2;
        private Utility.UControl.txtBoxWithDate userControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_mendDate;
    }
}