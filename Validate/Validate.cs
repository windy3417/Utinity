using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Utility.Validate
{
  public static class Validate
    {
        /// <summary>
        /// 文本框不能为空校验
        /// </summary>
        public static bool inputVlidate(TableLayoutPanel recordeContainer)
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

        public static bool inputVlidate(Panel panHeader)
        {

            for (int i = 0; i < panHeader.Controls.Count;)
            {


                if (panHeader.Controls[i].Text == "" || panHeader.Controls[i].Text == null)
                {
                    MessageBox.Show(panHeader.Controls[i].Tag + "必填项不能为空", "输入校验");
                    ((TextBox)panHeader.Controls[i]).BackColor = Color.Red;
                    ((TextBox)panHeader.Controls[i]).Focus();
                    return false;
                    
                }


                i++;


            }

            //if the content of all textBox is not empty,change the backColor of it 
            foreach (var item in panHeader.Controls)
            {

                if (item.GetType().Name == "TextBox")
                {

                    ((TextBox)item).BackColor = Color.White;

                }


            }
            return true;


        }

        /// <summary>
        /// 验证是否为数字
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool validateNumber(string number)
        {
            if (Regex.Match(number, "^\\d+$").Success)
            {
                return true;
            }

            return false;
        }
    }
}
