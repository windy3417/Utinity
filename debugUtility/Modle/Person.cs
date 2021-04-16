using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace debugUtility.Modle
{
   public class Person
    {
        [Display(Name = "Id")]
        [Browsable(false)]
        public int? Id { get; set; }

        [Display(Name = "First Name", Description = "First name.", Order = 1)]
        [UIHint("TextBox")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", Description = "Last name", Order = 2)]
        [UIHint("TextBox")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date", Description = "Date of birth.", Order = 4)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        [UIHint("Calendar")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Homepage", Description = "Url of homepage.", Order = 5)]
        [UIHint("Link")]
        public string Url { get; set; }

        [Display(Name = "Member", Description = "Is member?", Order = 3)]
        [UIHint("CheckBox")]
        public bool IsMember { get; set; }
    }
}
