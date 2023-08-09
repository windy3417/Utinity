using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.Windows.Forms;

namespace Utility.Excel
{
    public class ExportExcel
    {

        /// <summary>
        /// 导出为Excel文件，使用NPOI.dll类
        /// </summary>
        /// <param name="dt">数据承载类为TataTable</param>
        /// <param name="reportName">导出文件名</param>
        public void ExportExcelWithNPOI(DataTable dt, string reportName)
        {
            try
            {
                //创建一个工作簿
                IWorkbook workbook = new HSSFWorkbook();

                //创建一个 sheet 表
                ISheet sheet = workbook.CreateSheet(reportName);

                //创建一行
                IRow rowH = sheet.CreateRow(0);

                //创建一个单元格
                ICell cell = null;

                //创建单元格样式
                ICellStyle cellStyle = workbook.CreateCellStyle();

                //创建格式
                IDataFormat dataFormat = workbook.CreateDataFormat();

                //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
                cellStyle.DataFormat = dataFormat.GetFormat("@");

                //设置列名
                foreach (DataColumn col in dt.Columns)
                {
                    //创建单元格并设置单元格内容
                    rowH.CreateCell(col.Ordinal).SetCellValue(col.Caption);

                    //设置单元格格式
                    rowH.Cells[col.Ordinal].CellStyle = cellStyle;
                }

                //写入数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //跳过第一行，第一行为列名
                    IRow row = sheet.CreateRow(i + 1);

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        cell = row.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][j].ToString());
                        cell.CellStyle = cellStyle;
                    }
                }

                //设置导出文件路径
                string path = Environment.CurrentDirectory + "\\";

                //设置新建文件路径及名称
                string savePath = path + reportName + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

                //创建文件
                FileStream file = new FileStream(savePath, FileMode.CreateNew, FileAccess.Write);

                //创建一个 IO 流
                MemoryStream ms = new MemoryStream();

                //写入到流
                workbook.Write(ms);

                //转换为字节数组
                byte[] bytes = ms.ToArray();

                file.Write(bytes, 0, bytes.Length);
                file.Flush();

                //还可以调用下面的方法，把流输出到浏览器下载
                //OutputClient(bytes);

                //释放资源
                bytes = null;

                ms.Close();
                ms.Dispose();

                file.Close();
                file.Dispose();

                workbook.Close();
                sheet = null;
                workbook = null;
                System.Diagnostics.Process.Start(savePath);
            }
            catch (Exception ex)
            {
               MessageBox.Show( ex.Message+ex.InnerException);
            }
        }

        /// <summary>
        /// 导出为Excel文件，使用NPOI.dll类
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="reportName"></param>
        public void ExportExcelWithNPOI(DataGridView dataGridView, string reportName)
        {
            try
            {
                #region 创建Excel表
                //非数据列不导出，设置可导出例数

                List<int> exportColumn = new List<int>();
                //创建一个工作簿

                IWorkbook workbook = new HSSFWorkbook();

                //创建一个 sheet 表
                ISheet sheet = workbook.CreateSheet(reportName);

                //创建一行
                IRow rowH = sheet.CreateRow(0);

                //创建一个单元格
                ICell cell = null;

                //创建单元格样式
                ICellStyle cellStyle = workbook.CreateCellStyle();

                //创建格式
                IDataFormat dataFormat = workbook.CreateDataFormat();

                //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
                cellStyle.DataFormat = dataFormat.GetFormat("@");

                #endregion

                #region 设置列名(表头)
                foreach (dynamic col in dataGridView.Columns)
                {
                    //创建单元格并设置单元格内容
                    //string s = col.GetType().Name;
                    //只导出文本例的值
                    if (col.GetType().Name != "DataGridViewCheckBoxColumn" & col.GetType().Name != "DataGridViewButtonColumn")
                    {
                        DataGridViewTextBoxColumn tbc = (DataGridViewTextBoxColumn)col;
                        rowH.CreateCell(col.Index).SetCellValue(tbc.HeaderText);
                        exportColumn.Add(col.Index);
                        //设置单元格格式，但报索引不在范围内，待查原因？
                        //rowH.Cells[col.Index].CellStyle = cellStyle;
                    }


                    //导出列表中所有存在值的单元格数据，如无值则报错

                    //DataGridViewTextBoxColumn tbc = (DataGridViewTextBoxColumn)col;
                    //rowH.CreateCell(col.Index).SetCellValue(col.HeaderText);
                    //exportColumn.Add(col.Index);
                    //设置单元格格式
                    //    rowH.Cells[col.Index].CellStyle = cellStyle;


                }
                #endregion

                
                #region 写入数据
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    //跳过第一行，第一行为列名
                    IRow row = sheet.CreateRow(i + 1);


                    foreach (int j in exportColumn)
                    {
                        //此cell不能创造excel表中的cell,仅仅是对excel工作表中的cell进行操作
                        cell = row.CreateCell(j);
                       //处理dataGridView中的值为null的问题
                        if (dataGridView.Rows[i].Cells[j].Value is null)
                        {
                            cell.SetCellValue("");
                        }
                        else
                        {
                            cell.SetCellValue(dataGridView.Rows[i].Cells[j].Value.ToString());
                        }
                        
                        cell.CellStyle = cellStyle;
                    }

                }
                #endregion

                #region 导出操作

                //设置导出文件路径
                string path = Environment.CurrentDirectory + "\\";

                //设置新建文件路径及名称
                string savePath = path + reportName + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

                //创建文件
                FileStream file = new FileStream(savePath, FileMode.CreateNew, FileAccess.Write);

                //创建一个 IO 流
                MemoryStream ms = new MemoryStream();

                //写入到流
                workbook.Write(ms);

                //转换为字节数组
                byte[] bytes = ms.ToArray();

                file.Write(bytes, 0, bytes.Length);
                file.Flush();

                //还可以调用下面的方法，把流输出到浏览器下载
                //OutputClient(bytes);

                //释放资源
                bytes = null;

                ms.Close();
                ms.Dispose();

                file.Close();
                file.Dispose();

                workbook.Close();
                sheet = null;
                workbook = null;
                System.Diagnostics.Process.Start(savePath);
                #endregion


            }
            catch (Exception ex)
            {
                MessageBox.Show("数据导出报错：" + ex.ToString() + ex.InnerException, "数据导出提示");
            }
        }

        public void ExportExcelWithNPOI<T>(List<T> content,int[] columnIndex,  string reportName)
        {
            try
            {
                #region 创建Excel表
                //非数据列不导出，设置可导出例数

                //List<int> exportColumn = new List<int>();
                //创建一个工作簿

                IWorkbook workbook = new HSSFWorkbook();

                //创建一个 sheet 表
                ISheet sheet = workbook.CreateSheet(reportName);

                //创建一行
                IRow rowH = sheet.CreateRow(0);

                //创建一个单元格
                ICell cell = null;

                //创建单元格样式
                ICellStyle cellStyle = workbook.CreateCellStyle();

                //创建格式
                IDataFormat dataFormat = workbook.CreateDataFormat();

                //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
                cellStyle.DataFormat = dataFormat.GetFormat("@");

                #endregion

            

                #region 写入数据
                for (int i = 0; i < content.Count; i++)
                {
                    //跳过第一行，第一行为列名
                    IRow row = sheet.CreateRow(i + 1);


                    foreach (int j in columnIndex)
                    {
                        //此cell不能创造excel表中的cell,仅仅是对excel工作表中的cell进行操作
                        cell = row.CreateCell(j);
                        
                        cell.SetCellValue(content.ElementAt(i).ToString());
                        
                        cell.CellStyle = cellStyle;
                    }

                }
                #endregion

                #region 导出操作

                //设置导出文件路径
                string path = Environment.CurrentDirectory + "\\";

                //设置新建文件路径及名称
                string savePath = path + reportName + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

                //创建文件
                FileStream file = new FileStream(savePath, FileMode.CreateNew, FileAccess.Write);

                //创建一个 IO 流
                MemoryStream ms = new MemoryStream();

                //写入到流
                workbook.Write(ms);

                //转换为字节数组
                byte[] bytes = ms.ToArray();

                file.Write(bytes, 0, bytes.Length);
                file.Flush();

                //还可以调用下面的方法，把流输出到浏览器下载
                //OutputClient(bytes);

                //释放资源
                bytes = null;

                ms.Close();
                ms.Dispose();

                file.Close();
                file.Dispose();

                workbook.Close();
                sheet = null;
                workbook = null;
                System.Diagnostics.Process.Start(savePath);
                #endregion


            }
            catch (Exception ex)
            {
                MessageBox.Show("数据导出报错：" + ex.ToString() + ex.InnerException, "数据导出提示");
            }
        }

    }
}
