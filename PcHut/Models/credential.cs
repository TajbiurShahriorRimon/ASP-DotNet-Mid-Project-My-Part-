//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcHut.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class credential
    {
        public int cred_id { get; set; }
        public int user_id { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
    
        public virtual user user { get; set; }
    }
}
