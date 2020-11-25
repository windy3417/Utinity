
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

using Utility.Modle;
using System.Collections.Generic;
using System.Configuration;
using Utility;
using System.Data.Entity;

namespace Utility.UI
{
    public partial class Frm_baseUser : Form
    {
        public Frm_baseUser()
        {
            InitializeComponent();
            this.initialize();

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        //List<UserModle> mList = new List<UserModle>();
        //最大客户编号
        //int maxCusCode;
        //dataGridView控件的数据来源，true为查询时绑定，
        //false为新增档案时的绑定


        enum saveOrChangeOrQueryMolde
        {
            save,
            change,
            query
        }

        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        //bool saveOrChangeFlag = true;
        string saveOrModifQueryFlag;
        #endregion


        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            tsb_modify.Enabled = false;
            this.tsb_save.Enabled = false;
            this.tsb_modify.Enabled = false;
            this.tsb_delete.Enabled = false;
            tsb_abandon.Enabled = false;
            this.dgv_person.AutoGenerateColumns = false;
            this.tableLayoutPanel1.Enabled = false;
            lbl_voucherStatus.Visible = false;


        }

        
        #region 输入校验

        /// <summary>
        /// 正则校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regValidating(object sender, CancelEventArgs e)
        {
            string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);
            if (!regex.Match(txt_userID.Text).Success)
            {

                //为空时不做正则判断
                if (this.txt_userID.TextLength == 0)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("请输入数字作为编码", "输入验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_userID.Text = "";
                    this.txt_userID.Focus();
                }


            };

        }

        /// <summary>
        /// 为空校验
        /// </summary>
        private bool inputValidate()
        {

            for (int i = 0; i < this.tableLayoutPanel1.Controls.Count;)
            {
                //if (this.tableLayoutPanel1.Controls[i].Name.Substring(0, 3) == "txt" & this.tableLayoutPanel1.Controls[i].Text == "")
                if (this.tableLayoutPanel1.Controls[i].Name != tbd_failure.Name)
                {
                    if (this.tableLayoutPanel1.Controls[i].Text == "" || this.tableLayoutPanel1.Controls[i].Text == null)
                    {
                        MessageBox.Show(this.tableLayoutPanel1.Controls[i].Tag + "不能为空", "输入校验");
                        return false;
                    }
                }

                i++;


            }
            return true;


        }
        #endregion

        #region 虚方法
                 
        
        #region 增删改查

       
      
        /// <summary>
        /// 保存数据
        /// </summary>
        protected virtual void saveDate()
        {

        }

        /// <summary>
        /// 查询数据
        /// </summary>
        protected virtual void queryDate()
        {

        }



        /// <summary>
        /// 修改客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_modify_Click(object sender, EventArgs e)
        {
            lbl_voucherStatus.Text = "档案状态：修改";
            lbl_voucherStatus.Visible = true;
            tsb_add.Enabled = false;

            tableLayoutPanel1.Enabled = true;
            //编码不能被修改
            txt_userID.Enabled = false;
            tsb_save.Enabled = true;

        }

    


        #endregion

        #endregion

        #region 窗体操作
        /// <summary>
        /// 关闭嵌入式窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        #endregion

        private void tsb_delete_Click(object sender, EventArgs e)
        {

            //if (dataGridView1.Rows.Count > 0)
            //{
            //   string selected = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //    if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            //    {

            //        DataMaitenanceContext db = new DataMaitenanceContext();

            //        List<UserModle> d = (from del in db.Users
            //                                      where del.userID ==selected
            //                                      select del).ToList<UserModle>();
            //        //移除数据库的数据

            //        db.Users.Remove(d[0]);
            //        db.SaveChanges();
            //        clearDate();

            //        //如果是在新增界面状态使用删除功能，则同时删除内存中的集合数据
            //        //数据库中的条件实体delCustomer不能成为内存中的待删除实体
            //        //即：customerList.Remove(delCustomer[0])返回false,故无法实现
            //        //内存当中的数据集记录删除;
            //        if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
            //        {

            //            List<UserModle> customer = mList.Where(c => c.userID == selected).ToList<UserModle>();
            //            mList.Remove(customer[0]);

            //        }
            //        bind_gv_dateSource();
            //    }
            //}

            return;

        }

        /// <summary>
        /// 保存客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {

            if (inputValidate())
            {
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                {
                    saveDate();

                    //bind_gv_dateSource();


                    clearDate();
                }
            }



        }

        /// <summary>
        /// 新增档案并自动生成客户编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      


        /// <summary>
        /// 删除选择定行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region 数据处理与绑定
        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>


        /// <summary>
        /// 清除录入或查询出的数据
        /// </summary>
        private void clearDate()
        {
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {

                //if (item.Name.Substring(0, 3) != "lbl")
                if (item.GetType() != typeof(Label))
                {
                    item.Text ="" ;
                }



            }
        }

     

        /// <summary>
        /// 选择当前行数据进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            clearDate();
            if (e.RowIndex > -1)
            {
                this.txt_userID.Text = this.dgv_person.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txt_userName.Text = this.dgv_person.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }




        }

        #endregion

        #region 菜单事件

        //增加档案
        private void Tsb_add_Click(object sender, EventArgs e)
        {

            lbl_voucherStatus.Text = "档案状态：新增";
            lbl_voucherStatus.Visible = true;

            //先清空查询时绑定的数据
            clearDate();
            //故增加数据源判定,否则连续增加时就无法在DataGridView中显示增加的记录
            if (saveOrModifQueryFlag != saveOrChangeOrQueryMolde.save.ToString())
            {
                saveOrModifQueryFlag = saveOrChangeOrQueryMolde.save.ToString();
                this.dgv_person.DataSource = null;
            }

            this.tsb_save.Enabled = true;
            tsb_abandon.Enabled = true;

            //新增与查询功能中的dataGridView数据源不同，且该数据源标记通过功能键触发选择
            //tsb_query.Enabled = false;
            tsb_modify.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;


            //给自定义日期控件赋值，其中的textBox控件为显示值
            //日期控件的文本为将需要存储的值
            this.tbd_effect.Controls[2].Text = DateTime.Now.ToString().Substring(0, 10);
            tbd_effect.Text = DateTime.Now.ToString().Substring(0, 10);

            ////取最大编号时速度太慢，三秒左右，同时最大号算法有误，取到第10号则不向上递增了???。
            //using (var db = new DataMaitenanceContext())
            //{
            //    UserModle customer = new UserModle();

            //    var custQuery = from cust in db.Users.AsNoTracking()

            //                    select cust.userID;
            //    if (custQuery.Count()==0)
            //    {
            //        maxCusCode = 1;
            //    }
            //    else
            //    {
            //        maxCusCode = Convert.ToInt32(custQuery.Max()) + 1;
            //    }



            //}
            //this.txt_cusCode.Text = maxCusCode.ToString();

            this.txt_userID.Focus();
            //表明当前dataGridView的数据源是内存集合数据

        }

        /// <summary>
        /// 查询档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            clearDate();
            lbl_voucherStatus.Text = "档案状态：查询";
            lbl_voucherStatus.Visible = true;

            saveOrModifQueryFlag = saveOrChangeOrQueryMolde.query.ToString();
            this.tsb_save.Enabled = false;
          
            this.tsb_modify.Enabled = true;

            this.tsb_delete.Enabled = true;

            queryDate();
           


        }
        #endregion

        #region 快捷键
        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        /// <summary>
        /// 删除功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyDown(object sender, KeyEventArgs e)
        {
            // if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            if (e.KeyCode == Keys.S && e.Control)
            {
                tsb_save.PerformClick(); //执行单击button1的动作      
            }
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }







        #endregion

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tsb_delete.Enabled = true;
        }

        /// <summary>
        /// 放弃新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_abandon_Click(object sender, EventArgs e)
        {
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_query.Enabled = true;
            tsb_add.Enabled = true;
            tsb_abandon.Enabled = false;
            clearDate();
            tableLayoutPanel1.Enabled = false;

        }
    }
}