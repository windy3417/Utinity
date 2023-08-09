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
    public class SetCellsValue
    {
        public void SetDateCell(string bookName, string sheetName, string ext, string[] cells, DateTime dateTime)
        {
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            ISheet sheet;

            #region read file, then colsed automaticaly,so can not write



            if (ext == ".xlsx")
            {
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);

                    //sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellType(CellType.Blank);
                    sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellValue(dateTime);


                }


                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    xSSF.Write(file);
                }


            }

            if (ext == ".xls")
            {
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);

                    //sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellType(CellType.Blank);
                    sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellValue(dateTime);

                }

                //write data to exiting file
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    hssfwb.Write(file);
                }




            }
            #endregion





        }

        public void SetStringCell(string bookName, string sheetName, string ext, string[] cellPosition, string content)
        {
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            ISheet sheet;

            #region read file, then colsed automaticaly,so can not write



            if (ext == ".xlsx")
            {
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);

                    //sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellType(CellType.Blank);
                    sheet.GetRow(Convert.ToInt32(cellPosition[0]) - 1).GetCell(Convert.ToInt32(cellPosition[1]) - 1).SetCellValue(content);

                }


                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    xSSF.Write(file);
                }


            }

            if (ext == ".xls")
            {
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);

                    //sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellType(CellType.Blank);
                    sheet.GetRow(Convert.ToInt32(cellPosition[0]) - 1).GetCell(Convert.ToInt32(cellPosition[1]) - 1).SetCellValue(content);

                }

                //write data to exiting file
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    hssfwb.Write(file);
                }




            }
            #endregion





        }

        public void SetStringCell<T>(string bookName, string sheetName,  int columnIdex, List<T> content)
        {
            XSSFWorkbook xSSF;
          
            ISheet sheet;

            #region read file, then colsed automaticaly,so can not write

                        
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);

                    for (int i = 0; i < content.Count; i++)
                    {
                        if (content.GetType().Equals(typeof(System.String)))
                        {
                            sheet.GetRow(i).GetCell(columnIdex - 1).SetCellType(CellType.String);
                            sheet.GetRow(i).GetCell(columnIdex - 1).SetCellValue(content.ToString());
                        }

                        if (content.GetType().Equals(typeof(System.Double)))
                        {
                            sheet.GetRow(i - 1).GetCell(columnIdex - 1).SetCellType(CellType.Numeric);
                            sheet.GetRow(i - 1).GetCell(columnIdex - 1).SetCellValue(Convert.ToDouble(content));

                        }

                        if (content.GetType().Equals(typeof(System.DateTime)))
                        {

                            sheet.GetRow(i - 1).GetCell(columnIdex - 1).SetCellValue(Convert.ToDateTime(content));

                        }

                    }



                }


                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    xSSF.Write(file);
                }


            

         
            #endregion





        }

        public void SetFixRegion<T>(string bookName, string sheetName, string fileExtentionName, int rowNo, int columnNo ,T content)
        {
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            ISheet sheet;
         

            if (fileExtentionName == ".xlsx")
            {

                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    xSSF = new XSSFWorkbook(file);
                    sheet = xSSF.GetSheet(sheetName);

                    if (content.GetType().Equals(typeof(System.String)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.String);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(content.ToString());
                    }

                    if (content.GetType().Equals(typeof(System.Double)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.Numeric);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToDouble(content));

                    }

                    if (content.GetType().Equals(typeof(System.DateTime)))
                    {

                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToDateTime(content));

                    }


                }

                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    xSSF.Write(file);
                }
                    


            }


            if (fileExtentionName == ".xls")
            {
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new HSSFWorkbook(file);
                    sheet = hssfwb.GetSheet(sheetName);


                    if (content.GetType().Equals(typeof(System.String)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.String);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(content.ToString());
                    }

                    if (content.GetType().Equals(typeof(System.Double)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.Numeric);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToDouble(content));

                    }

                    if (content.GetType().Equals(typeof(System.DateTime)))
                    {
                       
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToDateTime(content));

                    }
                }

                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    hssfwb.Write(file);
                }
               

            }













        }
    }
}

