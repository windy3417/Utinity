﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DebugUtility.DAL
{extern alias EF;
    using System;
    using EF::System.Data.Entity;
    using EF::System.Data.Entity.Infrastructure;
    using DebugUtility.Modle;

    public partial class TestContext : DbContext
    {
        //public TestContext() : base(Utility.Sql.Sqlhelper.sqlConnection(), true)
        //{
            
        //}

        public TestContext() : base("name=test")
        {

        }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<UserModle> Users { get; set; }

    }
}
