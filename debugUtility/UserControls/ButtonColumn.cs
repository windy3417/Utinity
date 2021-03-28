using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.UControl;

namespace debugUtility.UserControls
{



    public class ButtonColumn : DataGridViewColumn
    {
        
        
        public ButtonColumn() : base(new ButtonCell())
        {
            
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(ButtonCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class ButtonCell : DataGridViewTextBoxCell
    {

        public ButtonCell()
            : base()
        {

        }

        /// <summary>
        /// 改变编辑控件的大小
        /// </summary>
        /// <param name="cellBounds"></param>
        /// <param name="cellClip"></param>
        /// <param name="cellStyle"></param>
        /// <param name="singleVerticalBorderAdded"></param>
        /// <param name="singleHorizontalBorderAdded"></param>
        /// <param name="isFirstDisplayedColumn"></param>
        /// <param name="isFirstDisplayedRow"></param>
        /// <returns></returns>
        // public override Rectangle PositionEditingPanel
        //(Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle,
        //       bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded,
        //       bool isFirstDisplayedColumn, bool isFirstDisplayedRow)
        // {
        //     cellBounds.Width *= 1;
        //     cellClip.Width = cellBounds.Width;
        //     return base.PositionEditingPanel(cellBounds, cellClip,
        //         cellStyle, true, true,
        //         isFirstDisplayedColumn, isFirstDisplayedRow);
        // }


        //public override void PositionEditingControl
        //    (bool setLocation, bool setSize, Rectangle cellBounds,
        //    Rectangle cellClip, DataGridViewCellStyle cellStyle,
        //    bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded,
        //    bool isFirstDisplayedColumn, bool isFirstDisplayedRow)
        //{
        //    Selected = true;
        //    setSize = true;

        //    cellBounds =base.ContentBounds;
        //    isFirstDisplayedColumn = false;
        //    isFirstDisplayedRow = false;

        //}

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            ButtonEditingControl ctl =
                DataGridView.EditingControl as ButtonEditingControl;
            
            
            // Use the default row value when Value property is null.
            //if (this.Value == null)
            //{
            //    ctl.Value = (DateTime)this.DefaultNewRowValue;
            //}
            //else
            //{
            //    ctl.Value = (DateTime)this.Value;
            //}
        }

        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that textBoxWithBtn uses.
                return typeof(ButtonEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.

                return typeof(DateTime);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                //return DateTime.Now;
              return  "";
            }
        }
    }

    /// <summary>
    /// 定义含button控件的textBox控件
    /// </summary>
    class ButtonEditingControl : TextBox, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;
        Button button = new Button();

        #region 属性
        public object Value { get; set; }

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public ButtonEditingControl()
        {

            InitializeControlsState();
            bindEvent();

            //Point  p= this.Location;

            //button.Location = new Point(p.X + this.Width-button.Width-4, p.Y);
            //this.SizeChanged += ButtonEditingControl_SizeChanged;
           

        }

        /// <summary>
        /// 初始化控件绑定
        /// </summary>
        void InitializeControlsState()
        {
            button.Parent = this;
            button.Width = 20;
            button.Height = this.Height;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Text = "…";
            button.Dock = DockStyle.Right;
        }

        void bindEvent()
        {
           
            //定位到参照按钮时的鼠标形状变化，
            //发现手型图标无法显示
            this.button.MouseMove += ButtonEditingControl_MouseMove;
            this.button.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor=Cursors.IBeam;
        }

        private void ButtonEditingControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }


        /// <summary>
        /// 实现button控件随着父控件的大小位置变化而变化，
        /// 待使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditingControl_SizeChanged(object sender, EventArgs e)
        {
            Point p = this.Location;

            button.Location = new Point(p.X + this.Width - button.Width - 4, p.Y);
        }

        //Implements the IDataGridViewEditingControl.EditingControlFormattedValue
        //property.
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value;
            }
            set
            {
                if (value is DateTime)
                {
                    // This will throw an exception of the string is
                    // null, empty, or not in the format of a date.
                    this.Value = DateTime.Parse((String)value);

                }
            }
        }

        //Implements the
        //IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        // Implements the
        // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            //this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            //this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        // Implements the IDataGridViewEditingControl.EditingControlRowIndex
        // property.
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey
        // method.
        public bool EditingControlWantsInputKey(
            Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit
        // method.
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        // Implements the IDataGridViewEditingControl
        // .RepositionEditingControlOnValueChange property.
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingControlDataGridView property.
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingControlValueChanged property.
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        // Implements the IDataGridViewEditingControl
        // .EditingPanelCursor property.
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }


    }


}

