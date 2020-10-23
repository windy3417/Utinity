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

namespace Excel
{
     public class  ExportExcel
    {
       
        /// <summary>
        /// 导出为Excel文件，使用NPOI.dll类
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="reportName"></param>
        public void ExportExcelWithNPOI(DataTable dt ,string reportName)
        {
            try
            {
                //创建一个工作簿
                IWorkbook workbook = new HSSFWorkbook();

                //创建一个 sheet 表
                ISheet sheet = workbook.CreateSheet(dt.TableName);

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
                string path = Environment.CurrentDirectory +"\\";

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
                ex.ToString();
            }
        }

        /// <summary>
        /// 导出为Excel文件，使用NPOI.dll类
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="reportName"></param>
        public void ExportExcelWithNPOI( DataGridView dataGridView, string reportName)
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
                foreach (DataGridViewTextBoxColumn col in dataGridView.Columns)
                {
                    //创建单元格并设置单元格内容
                    rowH.CreateCell(col.Index).SetCellValue(col.HeaderText);
                  

                    //设置单元格格式
                    rowH.Cells[col.Index].CellStyle = cellStyle;
                }

                //写入数据
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    //跳过第一行，第一行为列名
                    IRow row = sheet.CreateRow(i + 1);

                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        cell = row.CreateCell(j);
                        cell.SetCellValue(dataGridView.Rows[i].Cells[j].Value.ToString());
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
                MessageBox.Show("数据导出报错："+ ex.ToString()+ex.InnerException,"数据导出提示");
            }
        }
    }
}
