using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.Style
{
    public class ButtonColumn : DataGridViewColumn
    {
        public ButtonColumn()
        {
            CellTemplate = new ButtonCell();
            this.RefButton = _button;
        }

        #region vary
        int callEditingCotrolAmount = 0;
        Button _button = new Button();
        #endregion

        #region property

        public Button RefButton { get; set; }
        #endregion

        public void AddButtonToEditingControl(DataGridViewEditingControlShowingEventArgs e, DataGridView dataGridView,
            string columnName)


        {
            DataGridViewTextBoxEditingControl textBox = e.Control as DataGridViewTextBoxEditingControl;
            //the refButton will display in the textBox though the column is not designated ,
            //so i think the eidtCotrol is the same one  for any same type column
            textBox.Controls.Clear();
            DataGridViewCell currentCell = dataGridView.CurrentCell;
            if (currentCell.ColumnIndex == dataGridView.Columns[columnName].Index)
            {
                

                if (textBox != null)
                {
                    //because the width of editingcotrol is vary between first and sencode time it is shown 
                    if (this.callEditingCotrolAmount == 0)
                    {
                        this.RefButton.Width = textBox.Height;
                        RefButton.Height = RefButton.Width;

                    }

                    callEditingCotrolAmount++;
                    RefButton.Text = "…";


                    RefButton.Anchor = AnchorStyles.Right;
                    //button.Margin.Bottom = 0;


                    RefButton.Location = new Point(textBox.Width - RefButton.Height - 3, -3);

                    textBox.Controls.Remove(RefButton);
                    textBox.Controls.Add(RefButton);

                }
                
                          



            }
        
            
        }
    }



    public class ButtonCell : DataGridViewTextBoxCell
    {
        private Button _button;
        private Rectangle _buttonBounds;

        protected override void OnDoubleClick(DataGridViewCellEventArgs e)
        {
            base.OnDoubleClick(e);

            if (_button == null)
            {
                _button = new Button
                {
                    Text = "…",
                    Visible = true
                };


                DataGridView.Controls.Add(_button);
            }

            _buttonBounds = new Rectangle(DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location, Size);

            _button.Location = _buttonBounds.Location;
            _button.Location.Offset(-10, 0);
            _button.Size = _buttonBounds.Size;
            _button.Width = _buttonBounds.Height;
        }

        protected override void OnContentClick(DataGridViewCellEventArgs e)
        {
            base.OnContentClick(e);
            if (_button == null)
            {
                _button = new Button
                {
                    Text = "…",
                    Visible = true
                };

                DataGridView.Controls.Add(_button);
            }

            _buttonBounds = new Rectangle(DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location, Size);

            _button.Location = _buttonBounds.Location;
            _button.Location.Offset(-10, 0);
            _button.Size = _buttonBounds.Size;
            _button.Width = _buttonBounds.Height;
        }
    }
}



