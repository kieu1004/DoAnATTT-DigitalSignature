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
    
    public partial class tbl_user
    {
        public tbl_user()
        {
            this.tbl_student_cipher = new HashSet<tbl_student_cipher>();
            this.tbl_student_plain = new HashSet<tbl_student_plain>();
        }
    
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int user_type_id { get; set; }
        public Nullable<int> sig_id { get; set; }
    
        public virtual tbl_key tbl_key { get; set; }
        public virtual ICollection<tbl_student_cipher> tbl_student_cipher { get; set; }
        public virtual ICollection<tbl_student_plain> tbl_student_plain { get; set; }
        public virtual tbl_usertype tbl_usertype { get; set; }
    }
}
