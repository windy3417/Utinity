﻿extern alias EF;
using EF::System.Data.Entity;
using DebugUtility.Modle;
using ReportTransfer.DAL.Model.U8;






namespace ReportTransfer.DAL
{
    class U8Context:DbContext
    {
        public U8Context()

           : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8), true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<GL_accsum> GL_accsum { get; set; }
        public virtual DbSet<code> Code { get; set; }
        public virtual DbSet<GradeDef_Base> GradeDef_Bases { get; set; }

        public virtual DbSet<AccInformation_Year> AccInformation { get; set; }




    }
}

