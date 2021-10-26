using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Utility.Model;

namespace Utility.DAL
{
  public  class AuthorityContext : DbContext
    {


        //public AuthorityContext(string connectionString)
        //    : base(connectionString)
        //{
        //}

        public AuthorityContext()
            : base("data source=192.168.10.39;initial catalog=authority;user=sa;password=1")
        {
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //throw new UnintentionalCodeFirstException();
            }

            public virtual DbSet<PersonModel> Person { get; set; }
           
        
    }
}
