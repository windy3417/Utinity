using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utility.Excel
{
  public  class ReadCellsValue
    {
        /// <summary>
        /// 获取多个单元格数据
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="sheetName"></param>
        /// <param name="ext"></param>
        /// <param name="cells">单元格索引，从0开始，而非EXCEL中的从1开始</param>
        /// <returns></returns>
        public List<string> readExcelWithNPOI(string bookName, string sheetName, string ext ,int[,] cells )
        {
                          
            using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
            {
                XSSFWorkbook xSSF;
                HSSFWorkbook hssfwb;
                ISheet sheet;

                if (ext == ".xlsx")
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);
                    List<string> cellsValue = new List<string>();
                    
                    for (int i = 0; i < cells.GetLength(0); i++)
                    {




                        //全部转换成字符串，否则遇到date或numric类型的数据需要更换取数方法
                        //注意是把二维数据中的值作为EXCEL单据格的索引号，而非二维数组中的索引等同于EXCEL单据格的索引号
                        sheet.GetRow(cells[i, 0]).GetCell(cells[i, 1]).SetCellType(CellType.String);

                            string cellValue = sheet.GetRow(cells[i, 0]).GetCell(cells[i, 1]).StringCellValue;
                            cellsValue.Add(cellValue);
                        

                    }

                    return cellsValue;
                }
                if (ext == ".xls")
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);
                    List<string> cellsValue = new List<string>();

                    for (int i = 0; i < cells.GetLength(0); i++)
                    {


                        //全部转换成字符串，否则遇到date或numric类型的数据需要更换取数方法
                        //注意是把二维数据中的值作为EXCEL单据格的索引号，而非二维数组中的索引等同于EXCEL单据格的索引号
                        sheet.GetRow(cells[i, 0]).GetCell(cells[i, 1]).SetCellType(CellType.String);

                        string cellValue = sheet.GetRow(cells[i, 0]).GetCell(cells[i, 1]).StringCellValue;
                        cellsValue.Add(cellValue);



                    }

                    return cellsValue;
                }

                return null;
             

            }

           

           
           
            
            
                
            }

        /// <summary>
        /// 获取一个单元格数据
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="sheetName"></param>
        /// <param name="ext"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        public string readExcelNPOI(string bookName, string sheetName, string ext, string[] cells)
        {

            using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
            {
                XSSFWorkbook xSSF;
                HSSFWorkbook hssfwb;
                ISheet sheet;

                if (ext == ".xlsx")
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);
                 


                        //全部转换成字符串，否则遇到date或numric类型的数据需要更换取数方法
                        //注意是把二维数据中的值作为EXCEL单据格的索引号，而非二维数组中的索引等同于EXCEL单据格的索引号
                        sheet.GetRow(Convert.ToInt32(cells[0])-1).GetCell(Convert.ToInt32(cells[1])-1).SetCellType(CellType.String);

                        string cellValue = sheet.GetRow(Convert.ToInt32(cells[0])-1).GetCell(Convert.ToInt32(cells[1])-1).StringCellValue;
                    return cellValue;




                }

                    
                
                if (ext == ".xls")
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);
                    List<string> cellsValue = new List<string>();

                 
                        //全部转换成字符串，否则遇到date或numric类型的数据需要更换取数方法
                        //注意是把二维数据中的值作为EXCEL单据格的索引号，而非二维数组中的索引等同于EXCEL单据格的索引号
                        sheet.GetRow(Convert.ToInt32(cells[0])-1).GetCell(Convert.ToInt32(cells[1])-1).SetCellType(CellType.String);

                        string cellValue = sheet.GetRow(Convert.ToInt32(cells[0])-1).GetCell(Convert.ToInt32(cells[1])-1).StringCellValue;
                      

                                       

                    return cellValue;
                }

                return null;


            }



        }

        /// <summary>
        /// 获取一个单元格数据,并以此单元格数据循环读取中的起始单元格
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="sheetName"></param>
        /// <param name="ext"></param>
        /// <param name="rowNo">行索引号从零开始</param>
        /// <param name="columnNo">列索引号从零开始</param>
        /// <returns></returns>
        public string readExcelWithNPOI(string bookName, string sheetName, string ext, int rowNo,int columnNo)
        {
                    

            using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
            {
                XSSFWorkbook xSSF;
                HSSFWorkbook hssfwb;
                ISheet sheet;
                string cellValue;

                if (ext == ".xlsx")
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);

                    sheet.GetRow(rowNo-1).GetCell(columnNo-1).SetCellType(CellType.String);
                    cellValue  = sheet.GetRow(rowNo-1).GetCell(columnNo-1).StringCellValue;
                    return cellValue;

                }

                               
                if (ext == ".xls")
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);

                    sheet.GetRow(rowNo-1).GetCell(columnNo-1).SetCellType(CellType.String);
                    cellValue = sheet.GetRow(rowNo-1).GetCell(columnNo-1).StringCellValue;
                        
                                                        

                    return cellValue;
                }

                return null;


            }








        }
    }
}
    

