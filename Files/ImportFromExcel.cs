using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Utility.Files
{
  public  class ImportFromExcel
    {
        /// <summary>
        /// 返回Excel文件名
        /// </summary>
        /// <returns></returns>
        public string OpenExcelFile() 
        {
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();
          
            openFileDialogExcel.Filter = "excel files (*.xls;*xlsx)|*.xls;*.xlsx";
            openFileDialogExcel.ShowDialog();
            return openFileDialogExcel.FileName;
        }

        /// <summary>
        /// 导入EXCEL表数据到dataGridView
        /// </summary>
        /// <param name="dataGridView">
        /// 欲绑定的UI元素
        /// </param>
        /// <param name="dataTable">导入后存储的中间数据类型</param>
        public void ImportFileFromExcel( DataGridView dataGridView ,DataTable dataTable)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand comm = new OleDbCommand();



            //获取excel文件名
            string excelFileName = this.OpenExcelFile();
            if (excelFileName.Length > 0)
            {
                string stringConectExcel = "Provider=Microsoft.ace.OLEDB.12.0;"
                    + "Data Source=" + excelFileName + ";" +
               "Extended Properties='Excel 12.0 xml;HDR=YES'";
                conn.ConnectionString = stringConectExcel;
                comm.CommandText = "select * from [sheet1$]";
                comm.Connection = conn;
                conn.Open();

                da.SelectCommand = comm;


                da.Fill(dataTable);

                dataGridView.DataSource = dataTable;

                conn.Close();

              


            }
        }
    }
}
