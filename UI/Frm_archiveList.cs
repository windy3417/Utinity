
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.Drawing;
using Utility;
using System.Data.Entity;

namespace Utility.UI
{
    public partial class Frm_archiveList : Form
    {
        public Frm_archiveList()
        {
            InitializeComponent();
            this.initialize();
            initiallizeDateSource();

        }

        #region 变量
     


        #endregion


        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);

            this.dgv_templet.AutoGenerateColumns = false;
            tsb_delete.Enabled = false;






        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initiallizeDateSource()
        {
            //初始化客户名称数据源

            //cmb_custName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).Select((c) => new { c.CusCode, c.CusName }).ToList();

            //cmb_custName.DisplayMember = "CusName";
            //cmb_custName.ValueMember = "CusCode";

            //dtp_incomeDateStart.Value = DateTime.Now.AddDays(-DateTime.Now.Day + 1);
        }

        #region 查询功能
        /// <summary>
        /// 查询称重单列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            query();

            if (dgv_templet.RowCount > 0)
            {
                tsb_delete.Enabled = true;
            }

        }


        /// <summary>
        /// 查询数据
        /// </summary>
        protected virtual void query (){
           
        }

        /// <summary>
        /// 穿透查询到单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex > -1)
        //    {

        //        var voucherNo = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        Frm_weighingSettltement f = new Frm_weighingSettltement();
        //        string tabPageText = f.Text;
        //        Utility.UI.EmbedForm embedForm = new Utility.UI.EmbedForm();
        //        //使用母窗体的属性信息，实现动态创建插入页签式窗体

        //        embedForm.openForm(f, tabPageText, (TabControl)this.Parent.Parent.Parent.Controls["tabControl1"], (Panel)this.TopLevelControl.Controls["panel1"]);


        //        f.tsb_query.PerformClick();
        //        f.rtxt_voucherNO.Text = voucherNo;
        //        f.btn_query.PerformClick();

        //    }
        //}

        /// <summary>
        /// 查询框快捷按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_query_Click(object sender, EventArgs e)
        {
            tsb_query.PerformClick();
        }
        #endregion

        #region 窗体操作


        private void closeParent(object seder, FormClosedEventArgs eventArgs)
        {
            this.Parent.Dispose();
        }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion



        #region 快捷键


        /// <summary>
        /// 删除功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_weighingList_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }
        #endregion


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("宋体", 12);
            e.Graphics.DrawString("菜单信息", font, Brushes.Red, 400, 20);
            e.Graphics.DrawString("时间" + DateTime.Now.ToLongDateString(), font, Brushes.Black, 20, 40);
            int x = 10;
            int y = 70;
            //PrintDataGridView.Print(dgvInfo2, true, e, ref x, ref y);
            //注意：PrintDataGridView该类位于上面所写的业务逻辑层之中
        }

        //打印预览按钮的单击事件中的代码如下：
        //在窗体中添加PrintDocument和PriintPreviewDialog控件，同时将PriintPreviewDialog属性中的Document属性设为PrintDocument的名称，
        //否则不能实现打印。
        private void tsb_print_Click(object sender, EventArgs e)
        {

            this.printPreviewDialog1.ShowDialog();
        }

       private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (dgv_templet.Rows.Count > 0)
            {
                var selected = dgv_templet.SelectedRows[0].Cells[0].Value;
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deleteModle(selected);
                    tsb_query.PerformClick();

                }
            }

            return;

        }

        /// <summary>
        /// 删除选定行
        /// </summary>
        /// <param name="selected"></param>
        protected virtual void deleteModle(object selected)
        {
            
        }

        //private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex > -1)
        //    {

        //        var voucherNo = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        Frm_weighingSettltement f = new Frm_weighingSettltement();
        //        string tabPageText = f.Text;
        //        Utility.UI.EmbedForm embedForm = new Utility.UI.EmbedForm();
        //        //使用母窗体的属性信息，实现动态创建插入页签式窗体

        //        embedForm.openForm(f, tabPageText, (TabControl)this.Parent.Parent.Parent.Controls["tabControl1"], (Panel)this.TopLevelControl.Controls["panel1"]);


        //        f.tsb_query.PerformClick();
        //        f.rtxt_voucherNO.Text = voucherNo;
        //        f.btn_query.PerformClick();
        //    }
        //}


        #region 打印




        class PrintDataGridView

        {
            private static List<DataGridViewCellPrint> CellPrintList = new List<DataGridViewCellPrint>();

            private static PageSetupDialog pageSetup = null;

            private static int printRowCount = 0;



            private static bool IsPrint = true;

            private static bool IsRole = true;

            private static int PoXTmp = 0;

            private static int PoYTmp = 0;

            private static int WidthTmp = 0;

            private static int HeightTmp = 0;

            private static int RowIndex = 0;



            /// <summary>

            /// 打印DataGridView控件

            /// </summary>

            /// <param name="dataGridView">DataGridView控件</param>

            /// <param name="includeColumnText">是否包括列标题</param>

            /// <param name="e">为 System.Drawing.Printing.PrintDocument.PrintPage 事件提供数据。</param>

            /// <param name="PoX">起始X坐标</param>

            /// <param name="PoY">起始Y坐标</param>

            public static void Print(DataGridView dataGridView, bool includeColumnText, PrintPageEventArgs eValue, ref int PoX, ref int PoY)

            {
                pageSetup = new PageSetupDialog();

                pageSetup.PageSettings = eValue.PageSettings;

                //pageSetup.Document;

                pageSetup.ShowDialog();

                try

                {
                    if (PrintDataGridView.IsPrint)

                    {
                        PrintDataGridView.printRowCount = 0;

                        PrintDataGridView.IsPrint = false;

                        PrintDataGridView.DataGridViewCellVsList(dataGridView, includeColumnText);

                        if (PrintDataGridView.CellPrintList.Count == 0)

                            return;

                        if (PoX > eValue.MarginBounds.Left)

                            PrintDataGridView.IsRole = true;

                        else

                            PrintDataGridView.IsRole = false;

                        PrintDataGridView.PoXTmp = PoX;

                        PrintDataGridView.PoYTmp = PoY;

                        PrintDataGridView.RowIndex = 0;

                        WidthTmp = 0;

                        HeightTmp = 0;

                    }

                    if (PrintDataGridView.printRowCount != 0)

                    {
                        if (IsRole)

                        {
                            PoX = PoXTmp = eValue.MarginBounds.Left;

                            PoY = PoYTmp = eValue.MarginBounds.Top;

                        }

                        else

                        {
                            PoX = PoXTmp;

                            PoY = PoYTmp;

                        }

                    }

                    while (PrintDataGridView.printRowCount < PrintDataGridView.CellPrintList.Count)

                    {
                        DataGridViewCellPrint CellPrint = CellPrintList[PrintDataGridView.printRowCount];

                        if (RowIndex == CellPrint.RowIndex)

                            PoX = PoX + WidthTmp;

                        else

                        {
                            PoX = PoXTmp;

                            PoY = PoY + HeightTmp;

                            if (PoY + HeightTmp > eValue.MarginBounds.Bottom)

                            {
                                HeightTmp = 0;

                                eValue.HasMorePages = true;

                                return;

                            }

                        }

                        using (SolidBrush solidBrush = new SolidBrush(CellPrint.BackColor))

                        {
                            RectangleF rectF1 = new RectangleF(PoX, PoY, CellPrint.Width, CellPrint.Height);

                            eValue.Graphics.FillRectangle(solidBrush, rectF1);

                            using (Pen pen = new Pen(Color.Black, 1))

                                eValue.Graphics.DrawRectangle(pen, Rectangle.Round(rectF1));

                            solidBrush.Color = CellPrint.ForeColor;

                            eValue.Graphics.DrawString(CellPrint.FormattedValue, CellPrint.Font, solidBrush, new Point(PoX + 2, PoY + 3));

                        }

                        WidthTmp = CellPrint.Width;

                        HeightTmp = CellPrint.Height;

                        RowIndex = CellPrint.RowIndex;

                        PrintDataGridView.printRowCount++;

                    }

                    PoY = PoY + HeightTmp;

                    eValue.HasMorePages = false;

                    PrintDataGridView.IsPrint = true;

                }

                catch (Exception ex)

                {
                    eValue.HasMorePages = false;

                    PrintDataGridView.IsPrint = true;

                    throw ex;

                }



            }



            /// <summary>

            /// 将DataGridView控件内容转变到 CellPrintList

            /// </summary>

            /// <param name="dataGridView">DataGridView控件</param>

            /// <param name="includeColumnText">是否包括列标题</param>

            private static void DataGridViewCellVsList(DataGridView dataGridView, bool includeColumnText)

            {
                CellPrintList.Clear();

                try

                {
                    int rowsCount = dataGridView.Rows.Count;

                    int colsCount = dataGridView.Columns.Count;



                    //最后一行是供输入的行时，不用读数据。

                    if (dataGridView.Rows[rowsCount - 1].IsNewRow)

                        rowsCount--;

                    //包括列标题

                    if (includeColumnText)

                    {
                        for (int columnsIndex = 0; columnsIndex < colsCount; columnsIndex++)

                        {
                            if (dataGridView.Columns[columnsIndex].Visible)

                            {
                                DataGridViewCellPrint CellPrint = new DataGridViewCellPrint();

                                CellPrint.FormattedValue = dataGridView.Columns[columnsIndex].HeaderText;

                                CellPrint.RowIndex = 0;

                                CellPrint.ColumnIndex = columnsIndex;

                                CellPrint.Font = dataGridView.Columns[columnsIndex].HeaderCell.Style.Font;

                                CellPrint.BackColor = Color.Orange;// dataGridView.ColumnHeadersDefaultCellStyle.BackColor;

                                CellPrint.ForeColor = dataGridView.ColumnHeadersDefaultCellStyle.ForeColor;

                                CellPrint.Width = dataGridView.Columns[columnsIndex].Width;

                                CellPrint.Height = dataGridView.ColumnHeadersHeight;

                                CellPrintList.Add(CellPrint);

                            }

                        }

                    }

                    //读取单元格数据

                    for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)

                    {
                        for (int columnsIndex = 0; columnsIndex < colsCount; columnsIndex++)

                        {
                            if (dataGridView.Columns[columnsIndex].Visible)

                            {
                                DataGridViewCellPrint CellPrint = new DataGridViewCellPrint();

                                CellPrint.FormattedValue = dataGridView.Rows[rowIndex].Cells[columnsIndex].FormattedValue.ToString();

                                if (includeColumnText)

                                    CellPrint.RowIndex = rowIndex + 1;//假如包括列标题则从行号1开始

                                else

                                    CellPrint.RowIndex = rowIndex;

                                CellPrint.ColumnIndex = columnsIndex;

                                CellPrint.Font = dataGridView.Rows[rowIndex].Cells[columnsIndex].Style.Font;

                                System.Drawing.Color TmpColor = System.Drawing.Color.Empty;

                                if (System.Drawing.Color.Empty != dataGridView.Rows[rowIndex].Cells[columnsIndex].Style.BackColor)

                                    TmpColor = dataGridView.Rows[rowIndex].Cells[columnsIndex].Style.BackColor;

                                else if (System.Drawing.Color.Empty != dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor)

                                    TmpColor = dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor;

                                else

                                    TmpColor = dataGridView.DefaultCellStyle.BackColor;

                                CellPrint.BackColor = TmpColor;

                                TmpColor = System.Drawing.Color.Empty;

                                if (System.Drawing.Color.Empty != dataGridView.Rows[rowIndex].Cells[columnsIndex].Style.ForeColor)

                                    TmpColor = dataGridView.Rows[rowIndex].Cells[columnsIndex].Style.ForeColor;

                                else if (System.Drawing.Color.Empty != dataGridView.Rows[rowIndex].DefaultCellStyle.ForeColor)

                                    TmpColor = dataGridView.Rows[rowIndex].DefaultCellStyle.ForeColor;

                                else

                                    TmpColor = dataGridView.DefaultCellStyle.ForeColor;

                                CellPrint.ForeColor = TmpColor;

                                CellPrint.Width = dataGridView.Columns[columnsIndex].Width;

                                CellPrint.Height = dataGridView.Rows[rowIndex].Height;

                                CellPrintList.Add(CellPrint);

                            }

                        }

                    }

                }

                catch { throw; }

            }



            private class DataGridViewCellPrint

            {
                private string _FormattedValue = "";

                private int _RowIndex = -1;

                private int _ColumnIndex = -1;

                private System.Drawing.Color _ForeColor = System.Drawing.Color.Black;

                private System.Drawing.Color _BackColor = System.Drawing.Color.White;

                private int _Width = 100;

                private int _Height = 23;

                private System.Drawing.Font _Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                /// <summary>

                /// 获取或设置单元格的字体。

                /// </summary>

                public System.Drawing.Font Font

                {
                    set { if (null != value) _Font = value; }

                    get { return _Font; }

                }

                /// <summary>

                /// 获取为显示进行格式化的单元格的值。

                /// </summary>

                public string FormattedValue

                {
                    set { _FormattedValue = value; }

                    get { return _FormattedValue; }

                }

                /// <summary>

                /// 获取或设置列的当前宽度 （以像素为单位）。默认值为 100。

                /// </summary>

                public int Width

                {
                    set { _Width = value; }

                    get { return _Width; }

                }

                /// <summary>

                /// 获取或设置列标题行的高度（以像素为单位）。默认值为 23。

                /// </summary>

                public int Height

                {
                    set { _Height = value; }

                    get { return _Height; }

                }

                /// <summary>

                /// 获取或设置行号。

                /// </summary>

                public int RowIndex

                {
                    set { _RowIndex = value; }

                    get { return _RowIndex; }

                }

                /// <summary>

                /// 获取或设置列号。

                /// </summary>

                public int ColumnIndex

                {
                    set { _ColumnIndex = value; }

                    get { return _ColumnIndex; }

                }

                /// <summary>

                /// 获取或设置前景色。

                /// </summary>

                public System.Drawing.Color ForeColor

                {
                    set { _ForeColor = value; }

                    get { return _ForeColor; }

                }

                /// <summary>

                /// 获取或设置背景色。

                /// </summary>

                public System.Drawing.Color BackColor

                {
                    set { _BackColor = value; }

                    get { return _BackColor; }

                }

            }





        }































        // 至此 运行程序点打印就可以出现打印预览


        #endregion

        private void tsb_export_Click(object sender, EventArgs e)
        {
            Excel.ExportExcel exportExcel = new Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgv_templet, "过磅结算单列表");
        }
    }
}