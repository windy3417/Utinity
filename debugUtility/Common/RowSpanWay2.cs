using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DebugUtility.Common
{
    class RowSpanWay2
    {
        //protected void GridView31_DataBound1(object sender, EventArgs e)
        //{
        //    for (int rowIndex = grdView31.Rows.Count - 2; rowIndex >= 0; rowIndex--)
        //    {
        //        GridViewRow gvRow = grdView31.Rows[rowIndex];
        //        GridViewRow gvPreviousRow = grdView31.Rows[rowIndex + 1];
        //        for (int cellCount = 0; cellCount < gvRow.Cells.Count; cellCount++)
        //        {
        //            if (gvRow.Cells[cellCount].Text == gvPreviousRow.Cells[cellCount].Text)
        //            {
        //                if (gvPreviousRow.Cells[cellCount].RowSpan < 2)
        //                {
        //                    gvRow.Cells[cellCount].RowSpan = 2;
        //                }
        //                else
        //                {
        //                    gvRow.Cells[cellCount].RowSpan =
        //                        gvPreviousRow.Cells[cellCount].RowSpan + 1;
        //                }
        //                gvPreviousRow.Cells[cellCount].Visible = false;
        //            }
        //        }
        //    }

        //}

    }
}
