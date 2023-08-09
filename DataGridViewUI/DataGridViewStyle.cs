using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.Style
{
    public class DataGridViewStyle
    {
        #region vary

        bool _amountFlag;
        DataGridView _dgvReport;
        #endregion

        #region property

        public bool AmountFlag { get =>  _amountFlag ; set => _amountFlag=value; }
        public DataGridView dgvReport { get => _dgvReport; set => _dgvReport = value; }

        #endregion

        #region construct function

        public DataGridViewStyle()
        {

        }

        public DataGridViewStyle(DataGridView dataGridView)
        {
            _amountFlag = true;
            _dgvReport = dataGridView;
            dataGridView.RowPostPaint += DataGridView_RowPostPaint;
            DataGridViewColumnHeaderStyle();
        }

      
        #endregion


        private void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DisplayRowNo(e, _dgvReport, _amountFlag);
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="e">RowPostPaint事件</param>
        /// <param name="datagridview">DataGridView控件</param>
        public void DisplayRowNo(DataGridViewRowPostPaintEventArgs e, DataGridView datagridview, bool amountFlag)
        {
            Color color = datagridview.RowHeadersDefaultCellStyle.ForeColor;
            using (SolidBrush b = new SolidBrush(color))
            {
                if ((e.RowIndex + 1) < datagridview.Rows.Count)
                {

                    if (datagridview.Rows[e.RowIndex].Selected)
                        color = datagridview.RowHeadersDefaultCellStyle.SelectionForeColor;
                    else
                        color = datagridview.RowHeadersDefaultCellStyle.ForeColor;
                  
                        //在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串
                        e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                            b, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 6);

                    
                }

                else
                {
                    if (amountFlag)
                    {
                        //在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串
                        DataGridViewCellStyle TotalColumnStyle = new System.Windows.Forms.DataGridViewCellStyle();
                        TotalColumnStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        TotalColumnStyle.Font = new Font(datagridview.Font, FontStyle.Bold);
                        e.Graphics.DrawString("合计", TotalColumnStyle.Font,
                            b, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 6);
                    }


                    else
                    {
                        e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                           b, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 6);
                    } 

                    
                }

            }






        }

        public void DisplayRowHeader(DataGridViewRowPostPaintEventArgs e, DataGridView D)
        {
            if ((e.RowIndex + 1) <= D.Rows.Count)
            {
                Color color = D.RowHeadersDefaultCellStyle.ForeColor;
                if (D.Rows[e.RowIndex].Selected)
                    color = D.RowHeadersDefaultCellStyle.SelectionForeColor;
                else
                    color = D.RowHeadersDefaultCellStyle.ForeColor;
                using (SolidBrush b = new SolidBrush(color))
                {
                    //在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                        b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 6);

                }

            }
        }


        /// <summary>
        /// 表头样式，局中、加粗
        /// </summary>
        /// <param name="dataGridView"></param>
        public void DataGridViewColumnHeaderStyle( DataGridView dataGridView)
        {
            //表头样式
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            style.ForeColor = Color.IndianRed;
            style.BackColor = Color.LightSkyBlue;
            style.Font = new Font(dataGridView.Font, FontStyle.Bold);

            dataGridView.ColumnHeadersDefaultCellStyle = style;
            //dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;

            dataGridView.AutoResizeColumns();

        }

        private void DataGridViewColumnHeaderStyle()
        {
            //表头样式
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            style.ForeColor = Color.IndianRed;
            style.BackColor = Color.LightSkyBlue;
            style.Font = new Font(_dgvReport.Font, FontStyle.Bold);

            _dgvReport.ColumnHeadersDefaultCellStyle = style;
            //dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;

            _dgvReport.AutoResizeColumns();

        }

        public void ThoundSeparate(DataGridView dataGridView, string columnName)
        {

            DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.Format = "N2";
            style.NullValue = null;
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns[columnName].DefaultCellStyle = style;

        }

        public void ThoundSeparate(DataGridView dataGridView, string[] columnNames)
        {

            DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.Format = "N2";
            style.NullValue = null;
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach (var item in columnNames)
            {
                dataGridView.Columns[item].DefaultCellStyle = style;

            }

        }

        public void FontBond(DataGridView dataGridView, string[] columns)
        {


            foreach (var item in columns)
            {
                dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[item].Style.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
        }
    }
}
