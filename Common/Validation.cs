using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility.Common
{
  public  class Validation
    {
      public  void DeleteBlankRows(DataGridView tableBody)
        {
            int blankCell = 0;
            for (int i = tableBody.Rows.Count - 1; i > 0; i--)
            {

                foreach (DataGridViewCell item in tableBody.Rows[i].Cells)
                {
                    if (item.Value is null || item.Value.ToString() == "")
                    {
                        blankCell++;

                    }
                    if (blankCell == tableBody.Columns.Count)
                    {
                        tableBody.Rows.RemoveAt(i);
                        blankCell = 0;
                    }
                }
            }
        }

      public  bool DataGridviewCellsValidation(DataGridView table)

        {
            foreach (DataGridViewRow item in table.Rows)
            {
                foreach (DataGridViewCell cell in item.Cells)
                {
                    if (cell.Value is null || cell.Value.ToString() == "")
                    {
                        MessageBox.Show($"第{cell.RowIndex + 1}行第{cell.DataGridView.Columns[cell.ColumnIndex].HeaderText}列的值不能为空！");
                        return false;
                    }
                }
            }

            return true;
        }

      public  bool HeaderValidation(Panel panHeader)
        {
            foreach (var item in panHeader.Controls)
            {
                if (item.GetType().Name == "TextBox" && ((TextBox)item).Text == "")
                {
                    MessageBox.Show("表头必填项未填写！");
                    ((TextBox)item).BackColor = Color.Red;
                    ((TextBox)item).Focus();
                    return false;
                }
            }

            //if the content of all textBox is not empty,change the backColor of it 
            foreach (var item in panHeader.Controls)
            {

                if (item.GetType().Name == "TextBox")
                {

                    ((TextBox)item).BackColor = Color.White;

                }


            }

            return true;
        }

      public void  HeaderClear(Panel panHeader)
        {
            for (int i = 0; i < panHeader.Controls.Count; i++)
            {
                if (panHeader.Controls[i].GetType().Name == "TextBox" || panHeader.Controls[i].GetType().Name == "ComboBox")
                {

                    panHeader.Controls[i].Text = "";
                }
            }
        }

    }
}
