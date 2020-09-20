using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UControl
{
    public partial class txtBoxWithDate : UserControl
    {
        public txtBoxWithDate()
        {
            InitializeComponent();
            dtp_inTextBox.Format = DateTimePickerFormat.Custom;
            dtp_inTextBox.CustomFormat = "";
            
        }

        private string _text;
       
        public override string  Text 
        { get{
                return _text;
            }
            set { _text = value; }
        }

        /// <summary>
        /// dateTimePick控件选择日期后生成值到textBox控件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_inTextBox.CustomFormat = "yyyy-mm-dd";
            dtp_inTextBox.Format = DateTimePickerFormat.Custom;
            txt_withDate.Text = dtp_inTextBox.Value.ToString().Substring(0, 10);
            _text = txt_withDate.Text;
            dtp_inTextBox.Checked = false;
            //注意属性中rightToLeftLayout的值等于true,否则控件的日期选择框在选择完日期后有字迹显示在框中
        }
    }
}
