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
    public partial class TextBoxWithButton : UserControl
    {
        public TextBox txtCode;
        public Button btnCode;
        public TextBoxWithButton()
        {
            InitializeComponent();
            this.txtCode = new TextBox();
            this.Controls.Add(this.txtCode);
            this.btnCode = new Button();
            this.Controls.Add(this.btnCode);
            this.renderControl();
        }
       

        public void renderControl()
        {
            this.txtCode.Location = new Point(0, 0);
            //this.txtCode.Width = 2 * this.Width / 3 - 17;
            this.txtCode.Width = this.Width + 115;
            this.txtCode.Height = this.Height;
            this.btnCode.Location = new Point(this.Width + 115, 0);
            this.btnCode.Width = 32;
            this.btnCode.Height = 21;
        }
    }
}
