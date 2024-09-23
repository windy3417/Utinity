using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility.Style
{
   public class TabControlStyle
    {
        /// <summary>
        /// custom header of tabpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TabControlDrawItem(TabControl tabControl, DrawItemEventArgs e)
        {

            TabPage tabPage = tabControl.TabPages[e.Index];


            string tabText = tabPage.Text;
            tabPage.ToolTipText = tabText;


            // Create a font for drawing the close button
            var closeButtonFont = new Font("Segoe UI", 8, FontStyle.Bold);

            // Calculate the bounds of the tab header text and the button
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            Rectangle textBounds = new Rectangle(tabBounds.Location, new Size(tabBounds.Width - 16, tabBounds.Height));

            Rectangle buttonBounds = new Rectangle(tabBounds.Right - 16, tabBounds.Top, 16, 16);


            // Use a Graphics object to measure the text width


            SizeF textSize = e.Graphics.MeasureString(tabText, tabPage.Font);

            // If the text overflows, replace the excess characters with an ellipsis
            if (textSize.Width > textBounds.Width)
            {
                int ellipsisWidth = TextRenderer.MeasureText("...", tabPage.Font).Width;
                int cutoff = 0;
                for (int i = tabText.Length - 1; i >= 0; i--)
                {
                    textSize = e.Graphics.MeasureString(tabText.Substring(0, i) + "...", tabPage.Font);
                    if (textSize.Width + ellipsisWidth <= e.Bounds.Width)
                    {
                        cutoff = i;
                        break;
                    }
                }
                tabText = tabText.Substring(0, cutoff) + "...";
            }

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };


            // Draw the tab header text in unslected status of tabpage 
            //TextRenderer.DrawText(e.Graphics, tabText, tabPage.Font, textBounds, tabPage.ForeColor,TextFormatFlags.VerticalCenter);

            e.Graphics.DrawString(tabText, tabPage.Font, Brushes.Black, tabBounds, sf);


            // Draw the button and fill backgroud when selected the tabpage


            if (e.Index == tabControl.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.SkyBlue), tabBounds);
                e.Graphics.DrawString(tabText, tabPage.Font, Brushes.Black, textBounds, sf);

                e.Graphics.DrawString("X", closeButtonFont, Brushes.Red, buttonBounds);
            }


            // Store the button bounds in the Tag property of the tabPage
            tabPage.Tag = buttonBounds;

        }
    }
}
