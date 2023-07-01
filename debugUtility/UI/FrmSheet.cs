using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Style;

namespace DebugUtility.UI
{
    public partial class FrmSheet : Form
    {
        public FrmSheet()
        {
            InitializeComponent();
            Utility.Style.ButtonColumn buttonColumn = new ButtonColumn();
            buttonColumn.HeaderText = "testButton";
            dataGridView1.Columns.Add(buttonColumn);

            DataGridViewTextBoxColumn invColumn = new DataGridViewTextBoxColumn();
            invColumn.Name = "invColumn";
            invColumn.HeaderText = "buttonColumn";
            dataGridView1.Columns.Add(invColumn);



        }

        #region vary 

        Button button = new Button();
        int callEditingCotrolAmount=0;
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            AddButtonToEditingControl(e,"invName");
        }

        private void AddButtonToEditingControl(DataGridViewEditingControlShowingEventArgs e, string colomnsName)
        {
            DataGridViewTextBoxEditingControl textBox = e.Control as DataGridViewTextBoxEditingControl;
            if (textBox != null)
            {


                DataGridViewCell currentCell = dataGridView1.CurrentCell;
                if (currentCell.ColumnIndex == dataGridView1.Columns[colomnsName].Index)
                {

                    //because the width of editingcotrol is vary between first and sencode time it is shown 
                    if (callEditingCotrolAmount == 0)
                    {
                        button.Width = textBox.Height;
                        button.Height = button.Width;

                    }

                    callEditingCotrolAmount++;
                    button.Text = "…";

                    button.MouseHover += Button_MouseHover;
                    button.Anchor = AnchorStyles.Right;
                    //button.Margin.Bottom = 0;
                    button.Click += Button_Click;

                    button.Location = new Point(textBox.Width - button.Height - 3, -3);

                    textBox.Controls.Remove(button);
                    textBox.Controls.Add(button);



                }
            }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            FrmTreeView f = new FrmTreeView();
            f.Show();
        }

        private void dataGridView1_EditModeChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    DataGridViewTextBoxEditingControl textBox = e.Control as DataGridViewTextBoxEditingControl;
        //    if (textBox != null)
        //    {
        //        //textBox.TextChanged -= TextBox_TextChanged;
        //        //textBox.TextChanged += TextBox_TextChanged;
        //        DataGridViewCell currentCell = dataGridView1.CurrentCell;
        //        if (currentCell.ColumnIndex ==dataGridView1.Columns["invColumn"].Index)
        //        {
        //            Button button = new Button();
        //            button.Text = "Click me";
        //            button.Click += Button_Click;

        //            //button.Location = new Point(textBox.Width - button.Width, 0);


        //           Rectangle _buttonBounds = new Rectangle(dataGridView1.GetCellDisplayRectangle(currentCell.ColumnIndex, currentCell.RowIndex, false).Location, Size);

        //            button.Location = _buttonBounds.Location;
        //            button.Location.Offset(-10, 0);
        //            button.Size = _buttonBounds.Size;
        //            button.Width = _buttonBounds.Height;

        //            textBox.Controls.Add(button);
        //        }
        //    }
        //}
    }
}

