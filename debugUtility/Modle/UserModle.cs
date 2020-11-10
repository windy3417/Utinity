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
        public string userID { get; set; }
        public string name { get; set; }
        public string pwd { get; set; }
        public DateTime RegistrationDate { get; set; }
        Nullable <DateTime> DateOfCancellation { get; set; }
    }
}
