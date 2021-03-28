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
    public partial class TextBoxWithBtn : UserControl
    {
        public TextBox txtCode;
        public Button btnCode;
        public TextBoxWithBtn()
        {
            InitializeComponent();
            this.txtCode = new TextBox();
            this.Controls.Add(this.txtCode);

            this.btnCode = new Button();
            this.Controls.Add(this.btnCode);
            this.renderControl();

            //当该控件嵌入到dataGridViewCell中时，
            //dataGridViewCell并没有成为该控件的容器，
            //因此推断该控件是动态定位到dataGridViewCell上的
            //(调试时提示parent为空)
            //this.Width = this.Parent.Width;
        }
       

        public void renderControl()
        {
            this.txtCode.Location = new Point(0, 0);
            //this.txtCode.Width = 2 * this.Width / 3 - 17;
            //this.txtCode.Width = this.Width + 50;
            this.txtCode.Width = this.Width - 32;
            this.txtCode.Height = this.Height;

            //this.btnCode.Location = new Point(this.Width + 50, 0);

            this.btnCode.Location = new Point(this.Width -32, 0);
            this.btnCode.Width = 32;
            this.btnCode.Height = 21;
        }
    }
}
