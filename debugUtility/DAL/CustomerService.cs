using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Utility;
using Utility.Sql;


namespace DebugUtility.DAL
{
    class CustomerService
    {
        List<CustomerSet> customerSets = new List<CustomerSet>();
        //CustomerSet customerSet = new CustomerSet();
        //string sql="select * from "
        //SqlDataReader SqlDataReader =Sqlhelper.GetSqlDataReader()

        public List<CustomerSet> getCustomerSets()
        {
            using (var db = new scrapSettleEntities())
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
                return db.CustomerSet.ToList<CustomerSet>();
                
                
            }
        }

        public DataTable getCustmer()
        {
            String sql = "select * from customerset";
            return Sqlhelper.GetDataTable(sql);

        }
    }
}
