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
    public partial class XmTxtBoxWithDate : UserControl
    {
        public XmTxtBoxWithDate()
        {
            InitializeComponent();
            //日期格式化
            dtp_inTextBox.CustomFormat = "yyyy-MM-dd";
            dtp_inTextBox.Format = DateTimePickerFormat.Custom;
            checkBox1.Visible = false;
            ContainerTextChange += textChanged;


        }



        private string _text;

        #region 事件
        public event EventHandler ContainerTextChange;

        /// <summary>
        /// 事件处理方法，当调用端口实例化该事件委托，则执行该方法，
        /// 该方法可被子类覆写
        /// </summary>
        /// <param name="e"></param>
        protected virtual void onContinerTextChange(EventArgs e)
        {
            ContainerTextChange?.Invoke(this, e);
        }

        private void textChanged(object sender, EventArgs e)
        {
            txt_withDate.Text = _text;
        }


        #endregion



        #region 属性
        //text属性用于前端存储时间数据，而不需要在控件容器中寻找日期控件的值
        public override string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text == value)
                {
                    return;
                }

                _text = value;
                //_text值变化了，则引发事件
                onContinerTextChange(EventArgs.Empty);


            }
        }
        #endregion



        /// <summary>
        /// dateTimePick控件选择日期后生成值到textBox控件中
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            //赋值给checkBox,如果直接赋值给textBox,则一激活dateTimePicker控件
            //（即便不是手动选择日期，只要代码中涉及到对该控件的操作，比如遍历容器当中的控件或Enable控件）
            //就会赋值给textBox，这样不符合前端使用者的本意，故使用CheckBox控件过渡
            txt_withDate.Text = "";
            checkBox1.Checked = false;
            //checkBox1.Text = dtp_inTextBox.Value.ToString().Substring(0, 10);
            checkBox1.Visible = true;
            checkBox1.Text = dtp_inTextBox.Text;

            //_text = txt_withDate.Text;
            //dtp_inTextBox.Checked = false;
            //注意属性中rightToLeftLayout的值等于true,
            //否则控件的日期选择框在选择完日期后有字迹显示在框中
        }



        /// <summary>
        /// checkBox选择后，设定文本框与自定义控件的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_withDate.Text = "";
            if (checkBox1.Checked == true)
            {
                txt_withDate.Text = dtp_inTextBox.Text;
                _text = dtp_inTextBox.Text;
                checkBox1.Text = "";
                checkBox1.Visible = false;
            }
            else
            {
                txt_withDate.Text = "";
                _text = "";
            }
        }

        /// <summary>
        /// 进入时，显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TxtBoxWithDate_Enter(object sender, EventArgs e)
        {
            if (txt_withDate.Text == "")
            {
                checkBox1.Visible = true;
                checkBox1.Text = dtp_inTextBox.Value.ToString().Substring(0, 10);
            }
        }

        /// <summary>
        /// 文本框鼠标进入且文本框无值时，显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_withDate_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_withDate.Text == "")
            {
                checkBox1.Visible = true;
                checkBox1.Text = dtp_inTextBox.Value.ToString().Substring(0, 10);
            }

        }

        private void

            textHander()
        {
            txt_withDate.Text = _text;
        }
    }
}
