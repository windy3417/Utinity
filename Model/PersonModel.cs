using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Utility.Model
{
    [Table("person")]
  public  class PersonModel
    {
      
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
            [Key]
            public string Code { get; set; }
            public string Name { get; set; }

            public string pwd { get; set; }

            public DateTime EffectDate { get; set; }


            public Nullable<System.DateTime> FailuerDate
            {
                get;

                set;
            }
        
    }
}
