﻿using NPOI.HSSF.UserModel;
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
        /// 
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="sheetName"></param>
        /// <param name="ext"></param>
        /// <param name="cells">单元格索引，从0开始，而非EXCEL中的从1开始</param>
        /// <returns></returns>
        public List<string> readExcelWithNPOI(string bookName, string sheetName, string ext ,int[,] cells )
        {
          
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            ISheet sheet;
           
            using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
            {
                if (ext == "xlsx")
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
                if (ext == "xls")
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
        }
    }
