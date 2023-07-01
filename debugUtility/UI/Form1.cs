using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DebugUtility.UI
{
    //参照录入表格实现思路：
    //通过dataGridView的Cells 的单击事件，在单元格内绘制带button的textBox自定义控件；
    //实现参照录入
    public partial class Form1 : Form
    {
        TextBoxButtonControl txtbtnControl;
        DataGridViewTextBoxColumn Code, Description;

        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtbtnControl.Visible = false;
        }



        private void txtbtnControl_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtbtnControl.Visible = false;
                this.txtbtnControl.txtCode.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"\\192.168.10.66";
            openFileDialog1.ShowDialog();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

    }

    class TextBoxButtonControl : UserControl
    {
        public TextBox txtCode;
        public Button btnCode;

        public TextBoxButtonControl(int width)

        {
            this.Width = width;
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
            //this.txtCode.Width = this.Width + 115;

            this.txtCode.Width = this.Width -32;
            this.txtCode.Height = this.Height;

            this.btnCode.Location = new Point(this.Width -32, 0);
            this.btnCode.Width = 32;
            this.btnCode.Height = 21;
        }
    }

}

