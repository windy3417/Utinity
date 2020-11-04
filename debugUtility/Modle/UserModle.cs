using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DebugUtility.Modle
{
   
    [Table("user")]
 public   class UserModle
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
