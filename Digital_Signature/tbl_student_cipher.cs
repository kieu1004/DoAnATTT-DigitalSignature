//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Digital_Signature
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_student_cipher
    {
        public int stu_id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public System.DateTime birthday { get; set; }
        public string graduation_year { get; set; }
        public string email { get; set; }
        public string place_of_birth { get; set; }
        public string phone { get; set; }
        public string religion { get; set; }
        public int user_id { get; set; }
        public int status { get; set; }
    
        public virtual tbl_user tbl_user { get; set; }
    }
}
