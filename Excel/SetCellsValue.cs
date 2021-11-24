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

        public void SetStringCell(string bookName, string sheetName, string ext, string[] cells, string content)
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
                    sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellValue(content);

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
                    sheet.GetRow(Convert.ToInt32(cells[0]) - 1).GetCell(Convert.ToInt32(cells[1]) - 1).SetCellValue(content);

                }

                //write data to exiting file
                using (FileStream file = new FileStream(bookName, FileMode.Open, FileAccess.Write))
                {
                    hssfwb.Write(file);
                }




            }
            #endregion





        }

        public void SetFixRegion<T>(string bookName, string sheetName, string ext, int rowNo, int columnNo ,T content)
        {
            XSSFWorkbook xSSF;
            HSSFWorkbook hssfwb;
            ISheet sheet;
         

            if (ext == ".xlsx")
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

                    if (content.GetType().Equals(typeof(System.Int32)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.Numeric);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToInt32(content));

                    }                    

                                                        
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


                    if (content.GetType().Equals(typeof(System.String)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.String);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(content.ToString());
                    }

                    if (content.GetType().Equals(typeof(System.Int32)))
                    {
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellType(CellType.Numeric);
                        sheet.GetRow(rowNo - 1).GetCell(columnNo - 1).SetCellValue(Convert.ToInt32(content));

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

