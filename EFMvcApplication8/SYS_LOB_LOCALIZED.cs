//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFMvcApplication8
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_LOB_LOCALIZED
    {
        public int ID { get; set; }
        public string CULTURE { get; set; }
        public string NAME { get; set; }
        public string SYS_CODE { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual SYS_LOB SYS_LOB { get; set; }
    }
}
