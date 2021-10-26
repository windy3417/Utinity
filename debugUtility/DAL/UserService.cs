using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utility;
using Utility.Sql;
using DebugUtility.Model;


namespace DebugUtility.DAL
{
    class UserService
    {
        List<UserModle> customerSets = new List<UserModle>();
        //CustomerSet customerSet = new CustomerSet();
        //string sql="select * from "
        //SqlDataReader SqlDataReader =Sqlhelper.GetSqlDataReader()

        public List<UserModle> getCustomerSets()
        {
            using (var db = new TestContext())
            {

                //循环写法

                //var query = from cus in db.CustomerSet
                //            select cus;
                //foreach (var item in query)
                //{
                //    //customerSet = item;
                //    customerSets.Add(item);
                //}
                //return customerSets;

                //简化写法
                return db.Users.ToList<UserModle>();


            }
        }

        public DataTable getCustmer()
        {
            //String sql = "select * from [WeighingSettlements]";
            String sql = "select * from [Customers]";
            return Sqlhelper.GetDataTable(sql);

        }
    }
}
