using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using ReflectionMagic;
using System.Reflection;

namespace DebugUtility.Model
{


    public class UserModle
    {
        [Key]
        public string userID { get; set; }
        public string name { get; set; }
        public string pwd { get; set; }
        public DateTime RegistrationDate { get; set; }
        Nullable<DateTime> DateOfCancellation { get; set; }
    }

    public class RefletionMagicCase
        {

        ////object foo2 = typeof(UserModle).InvokeMember("GetOtherClass",
        ////    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod,
        ////    null, UserModle, null);

        //PropertyInfo propInfo = UserModle.GetType().GetProperty("SomeProp",
        //                BindingFlags.Instance | BindingFlags.NonPublic);

        //string val = (string)propInfo.GetValue(foo2, null);


    }
}
