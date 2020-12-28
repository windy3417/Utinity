using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.Validate
{
  public  class Validate
    {
        /// <summary>
        /// 文本框不能为空校验
        /// </summary>
        public bool inputVlidate(TableLayoutPanel recordeContainer)
        {

            for (int i = 0; i < recordeContainer.Controls.Count;)
            {
                            
                
                    if (recordeContainer.Controls[i].Text == "" || recordeContainer.Controls[i].Text == null)
                    {
                        MessageBox.Show(recordeContainer.Controls[i].Tag + "不能为空", "输入校验");
                        return false;
                    }
                

                i++;


            }
            return true;


        }
    }
}
