using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Utility.Excel
{
    public class ImportFromExcel
    {
        /// <summary>
        /// 返回Excel文件名
        /// </summary>
        /// <returns></returns>
        public string OpenExcelFile(out string ext)
        {
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();

            
            openFileDialogExcel.Filter = "excel files (*.xls;*xlsx)|*.xls;*.xlsx";
            openFileDialogExcel.ShowDialog();

            ext = openFileDialogExcel.DefaultExt;
            return openFileDialogExcel.FileName;
        }

        /// <summary>
        /// 导入EXCEL表数据到dataGridView
        /// </summary>
        /// <param name="dataGridView">
        /// 欲绑定的UI元素
        /// </param>
        /// <param name="dataTable">导入后存储的中间数据类型</param>
        public void ImportFileFromExcel(DataGridView dataGridView, DataTable dataTable)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand comm = new OleDbCommand();



            //获取excel文件名
            string ext;
            string excelFileName = this.OpenExcelFile(out ext);
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

        /// <summary>
        /// 暂未使用
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="dataTable"></param>
        public void ImportFileFromExcelWithNPOI(DataGridView dataGridView, DataTable dataTable)
        {
            string ext;
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            string excelFileName = this.OpenExcelFile(out ext);
            using (FileStream file = new FileStream(excelFileName, FileMode.Open, FileAccess.Read))
            {
                if (ext=="xls")
                {
                    xSSF = new XSSFWorkbook(file);
                }
                if (ext=="xlsx")
                {
                    hssfwb = new HSSFWorkbook(file);
                }

                hssfwb = new HSSFWorkbook(file);

            }

            ISheet sheet = hssfwb.GetSheet("Arkusz1");
            for (int row = 0; row <= sheet.LastRowNum; row++)
            {
                if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                {
                    MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                }
            }
        }


        public void ReadExcelWithNPOI(DataGridView dataGridView,DataTable dataTable)
        {
            try
            {
                string ext;
                //获取excel文件名
                string excelFileName = this.OpenExcelFile(out ext);

                if (System.IO.File.Exists(excelFileName))
                {

                    IWorkbook workbook = null;  //IWorkbook determina si es xls o xlsx              
                    ISheet worksheet = null;
                    string first_sheet_name = "";

                    using (FileStream FS = new FileStream(excelFileName, FileMode.Open, FileAccess.Read))
                    {
                        workbook = WorkbookFactory.Create(FS);          //Abre tanto XLS como XLSX
                        worksheet = workbook.GetSheetAt(0);    //Obtener Hoja por indice
                        first_sheet_name = worksheet.SheetName;         //Obtener el nombre de la Hoja

                        dataTable = new DataTable(first_sheet_name);
                        dataTable.Rows.Clear();
                        dataTable.Columns.Clear();


                        // Leer Fila por fila desde la primera
                        for (int rowIndex = 0; rowIndex <= worksheet.LastRowNum; rowIndex++)
                        {
                            DataRow NewReg = null;
                            IRow row = worksheet.GetRow(rowIndex);
                            IRow row2 = null;
                            IRow row3 = null;

                            if (rowIndex == 0)
                            {
                                row2 = worksheet.GetRow(rowIndex + 1); //Si es la Primera fila, obtengo tambien la segunda para saber el tipo de datos
                                row3 = worksheet.GetRow(rowIndex + 2); //Y la tercera tambien por las dudas
                            }

                            if (row != null) //null is when the row only contains empty cells 
                            {
                                if (rowIndex > 0) NewReg = dataTable.NewRow();

                                int colIndex = 0;
                                //Leer cada Columna de la fila
                                foreach (ICell cell in row.Cells)
                                {
                                    object valorCell = null;
                                    string cellType = "";
                                    string[] cellType2 = new string[2];

                                    if (rowIndex == 0) //Asumo que la primera fila contiene los titlos:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            ICell cell2 = null;
                                            if (i == 0) { cell2 = row2.GetCell(cell.ColumnIndex); }
                                            else { cell2 = row3.GetCell(cell.ColumnIndex); }

                                            if (cell2 != null)
                                            {
                                                switch (cell2.CellType)
                                                {
                                                    case CellType.Blank: break;
                                                    case CellType.Boolean: cellType2[i] = "System.Boolean"; break;
                                                    case CellType.String: cellType2[i] = "System.String"; break;
                                                    case CellType.Numeric:
                                                        if (HSSFDateUtil.IsCellDateFormatted(cell2)) { cellType2[i] = "System.DateTime"; }
                                                        else
                                                        {
                                                            cellType2[i] = "System.Double";  //valorCell = cell2.NumericCellValue;
                                                        }
                                                        break;

                                                    case CellType.Formula:
                                                        bool continuar = true;
                                                        switch (cell2.CachedFormulaResultType)
                                                        {
                                                            case CellType.Boolean: cellType2[i] = "System.Boolean"; break;
                                                            case CellType.String: cellType2[i] = "System.String"; break;
                                                            case CellType.Numeric:
                                                                if (HSSFDateUtil.IsCellDateFormatted(cell2)) { cellType2[i] = "System.DateTime"; }
                                                                else
                                                                {
                                                                    try
                                                                    {
                                                                        //DETERMINAR SI ES BOOLEANO
                                                                        if (cell2.CellFormula == "TRUE()") { cellType2[i] = "System.Boolean"; continuar = false; }
                                                                        if (continuar && cell2.CellFormula == "FALSE()") { cellType2[i] = "System.Boolean"; continuar = false; }
                                                                        if (continuar) { cellType2[i] = "System.Double"; continuar = false; }
                                                                    }
                                                                    catch { }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    default:
                                                        cellType2[i] = "System.String"; break;
                                                }
                                            }
                                        }

                                        //Resolver las diferencias de Tipos
                                        if (cellType2[0] == cellType2[1]) { cellType = cellType2[0]; }
                                        else
                                        {
                                            if (cellType2[0] == null) cellType = cellType2[1];
                                            if (cellType2[1] == null) cellType = cellType2[0];
                                            if (cellType == "") cellType = "System.String";
                                        }

                                        //Obtener el nombre de la Columna
                                        string colName = "Column_{0}";
                                        try { colName = cell.StringCellValue; }
                                        catch { colName = string.Format(colName, colIndex); }

                                        //Verificar que NO se repita el Nombre de la Columna
                                        foreach (DataColumn col in dataTable.Columns)
                                        {
                                            if (col.ColumnName == colName) colName = string.Format("{0}_{1}", colName, colIndex);
                                        }

                                        //Agregar el campos de la tabla:
                                        DataColumn codigo = new DataColumn(colName, System.Type.GetType(cellType));
                                        dataTable.Columns.Add(codigo); colIndex++;
                                    }
                                    else
                                    {
                                        //Las demas filas son registros:
                                        switch (cell.CellType)
                                        {
                                            case CellType.Blank: valorCell = DBNull.Value; break;
                                            case CellType.Boolean: valorCell = cell.BooleanCellValue; break;
                                            case CellType.String: valorCell = cell.StringCellValue; break;
                                            case CellType.Numeric:
                                                if (HSSFDateUtil.IsCellDateFormatted(cell)) { valorCell = cell.DateCellValue; }
                                                else { valorCell = cell.NumericCellValue; }
                                                break;
                                            case CellType.Formula:
                                                switch (cell.CachedFormulaResultType)
                                                {
                                                    case CellType.Blank: valorCell = DBNull.Value; break;
                                                    case CellType.String: valorCell = cell.StringCellValue; break;
                                                    case CellType.Boolean: valorCell = cell.BooleanCellValue; break;
                                                    case CellType.Numeric:
                                                        if (HSSFDateUtil.IsCellDateFormatted(cell)) { valorCell = cell.DateCellValue; }
                                                        else { valorCell = cell.NumericCellValue; }
                                                        break;
                                                }
                                                break;
                                            default: valorCell = cell.StringCellValue; break;
                                        }
                                        //Agregar el nuevo Registro
                                        if (cell.ColumnIndex <= dataTable.Columns.Count - 1) NewReg[cell.ColumnIndex] = valorCell;
                                    }
                                }
                            }
                            if (rowIndex > 0) dataTable.Rows.Add(NewReg);
                        }
                        dataTable.AcceptChanges();
                        dataGridView.DataSource = dataTable;
                    }
                }
                else
                {
                    throw new Exception("ERROR 404: El archivo especificado NO existe.");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
    
}
