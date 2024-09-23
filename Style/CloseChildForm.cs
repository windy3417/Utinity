using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility.Style
{
  public  class CloseChildForm
    {
        /// <summary>
        /// colse the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Close(TabControl tabControl, MouseEventArgs e)
        {

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                TabPage tabPage = tabControl.TabPages[i];
                Rectangle buttonBounds = (Rectangle)tabPage.Tag;

                if (buttonBounds.Contains(e.Location))
                {
                    // Close the child form of the tabPage
                    Form childForm = tabPage.Controls[0] as Form;
                    childForm.Close();

                    //Remove the tabPage from the tabControl
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }


        }
    }
}
