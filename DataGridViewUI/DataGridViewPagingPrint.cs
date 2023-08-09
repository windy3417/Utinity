using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility.DataGridViewUI
{
  public  class DataGridViewPagingPrint
    {
        #region vary

       
        StringFormat strFormat;
        bool bFirstPage;
        bool bNewPage;
        int iHeaderHeight;
        int iCellHeight;
        int iRow;
        //record the rows printed
        int iCount;
        float iTotalWidth;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
                    

        #endregion
      

        void InitialPagingParameter(DataGridView dgv)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                // recaculate the width、left、height
                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                //iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;

                foreach (DataGridViewColumn dgvGridCol in dgv.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrintDataFromDataGridView(System.Drawing.Printing.PrintPageEventArgs e, string title, DataGridView dgv)
        {

            InitialPagingParameter(dgv);

            try
            {
                #region initial position and font

                Font titleFont = new Font("Arial", 20, FontStyle.Bold);
                //Set the left margin of table body
                int iLeftMargin = e.MarginBounds.Left - 50;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;

                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = e.MarginBounds.Left;
                int titleWidth = (int)(e.Graphics.MeasureString(title,
                            new Font("Arial", 20, FontStyle.Bold), e.MarginBounds.Width).Width);
                #endregion


                #region set or get the cell width and header height For the first page to print

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgv.Columns)
                    {

                        //iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                        //    (double)iTotalWidth * (double)iTotalWidth *
                        //    ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width)));

                        //add 21 px for blank between header and body
                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 21;


                        // Save width and height of headers

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                #endregion


                #region print table 
                while (iRow <= dgv.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgv.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;


                    //Check whether the current page settings allows more rows to print

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            #region Draw title
                            e.Graphics.DrawString(title,
                                titleFont,
                                Brushes.Black,
                                (e.MarginBounds.Right - titleWidth) / 2,
                                e.MarginBounds.Top - e.Graphics.MeasureString(title, titleFont, e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();

                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(dgv.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgv.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                                new Font(new Font(dgv.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            iTopMargin = e.MarginBounds.Top;
                            #endregion


                            #region Draw Columns  known as header 

                            iCount = 0;

                            foreach (DataGridViewColumn GridCol in dgv.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }

                            bNewPage = false;

                            iTopMargin += iHeaderHeight;
                        }
                        #endregion





                        #region Draw Columns Contents  known as body of table 

                        iCount = 0;
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                        #endregion


                    }

                    iRow++;
                    iTopMargin += iCellHeight;
                }
                #endregion


                //If more lines exist, print another page.

                if (bMorePagesToPrint)
                    e.HasMorePages = true;//raise print envet
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
