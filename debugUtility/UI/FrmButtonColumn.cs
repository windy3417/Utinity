using debugUtility.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugUtility.UI
{
    public partial class FrmButtonColumn : Form
    {
        public FrmButtonColumn()
        {
            InitializeComponent();
                      
        }

        void InitializeControlsState()
        {
             this.dgvButonColumn.Dock = DockStyle.Fill;
            this.Controls.Add(this.dgvButonColumn);
            this.Load += new EventHandler(Form1_Load);
     
          
            this.Text = "DataGridView calendar column demo";
        }

        #region 变量
        enum ColumnNames
        {
            buttonColumn,
            accountCode
        }

        #endregion

        #region 内部方法

        void CreateColumn()
        {
            DataGridViewTextBoxColumn t = new DataGridViewTextBoxColumn();
            t.HeaderText = "参照按纽";
            t.Name = ColumnNames.buttonColumn.ToString();

            DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();
            c.HeaderText = "formula";

            ButtonColumn col = new ButtonColumn();
            col.HeaderText = "button";
            col.Name = ColumnNames.accountCode.ToString();
            col.Width = 300;
            

            CalendarColumn col2 = new CalendarColumn();
            this.dgvButton.Columns.AddRange(t, col, c, col2);
            
        }
        #endregion

        private void DgvButonColumn_EditingControlShowing
            (object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int columnIndex = dgvButonColumn.CurrentCell.ColumnIndex;
            //e.Control.Width = dgvButonColumn.Columns[columnIndex].Width;
            e.Control.Controls.Add(new Button());
        }

        private DataGridView dgvButonColumn = new DataGridView();

         
        private void Form1_Load(object sender, EventArgs e)
        {

            CreateColumn();
        }

        private void dgvButton_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
          dgvButton.Columns[ColumnNames.buttonColumn.ToString()].Index)
            {
                dgvButonColumn.EditingControlShowing += DgvButonColumn_EditingControlShowing;
            } 
        }

        private void dgvButton_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
        dgvButton.Columns[ColumnNames.accountCode.ToString()].Index)
            {
                dgvButonColumn.EditingControlShowing += DgvButonColumn_EditingControlShowing;
                //int columnIndex = dgvButonColumn.CurrentCell.ColumnIndex;
                //int rowIndex = dgvButonColumn.CurrentRow.Index;
                //DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                //dgvButonColumn.CurrentRow.Cells[ColumnNames.buttonColumn.ToString()].InitializeEditingControl(
                //   rowIndex, "", cellStyle);
                    
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Cross;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Cursor = Cursors.Cross;
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            this.button1.Cursor = Cursors.Cross;
            this.Cursor = Cursors.Cross;
            this.button1.BackColor = Color.Blue;
        }
    }
}
