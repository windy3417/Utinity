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

            this.Code = new DataGridViewTextBoxColumn();
            this.Code.Name = "FilePath";
            this.Code.Width = 200;
            this.Code.Resizable = DataGridViewTriState.False;
            this.dataGridView1.Columns.Add(Code);

            this.Description = new DataGridViewTextBoxColumn();
            this.Description.Name = "Description";
            this.Description.Width = 150;
            this.dataGridView1.Columns.Add(Description);

          
                              

           

          

            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtbtnControl.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Code.Index)
            {
                try
                {

                    //adding textboxbutton control at code column...

                    Rectangle rect = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    this.txtbtnControl = new TextBoxButtonControl(rect.Size.Width);
                    this.txtbtnControl.Visible = false;
                    this.dataGridView1.Controls.Add(this.txtbtnControl);
                    this.txtbtnControl.btnCode.Click += new EventHandler(btnCode_Click);

                    this.txtbtnControl.Leave += new EventHandler(txtbtnControl_Leave);
                    this.txtbtnControl.txtCode.TextChanged += new EventHandler(txtCode_TextChanged);

                    this.txtbtnControl.Location = rect.Location;
                    this.txtbtnControl.Size = rect.Size;
                    this.txtbtnControl.btnCode.Text = "...";
                    this.txtbtnControl.Visible = true;
                    this.txtbtnControl.Focus();
                    if (!string.IsNullOrEmpty(this.dataGridView1.CurrentRow.Cells[Code.Name].Value.ToString()))
                    {
                        this.txtbtnControl.txtCode.Text = this.dataGridView1.CurrentRow.Cells[Code.Name].Value.ToString();
                    }
                    else
                    {
                        this.txtbtnControl.txtCode.Text = "";
                    }
                }
                catch (Exception) { }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (this.txtbtnControl.txtCode.Modified)
            {
                this.dataGridView1.CurrentRow.Cells[Code.Name].Value = this.txtbtnControl.txtCode.Text;
            }
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

        private void btnCode_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = dialog.FileName.ToString();
                    txtbtnControl.txtCode.Text = dialog.FileName.ToString();
                }
                catch (Exception)
                {
                }
            }
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

