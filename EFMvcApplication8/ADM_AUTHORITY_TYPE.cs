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
    
    public partial class ADM_AUTHORITY_TYPE
    {
        public ADM_AUTHORITY_TYPE()
        {
            this.ADM_FUNCTION_ACCESS = new HashSet<ADM_FUNCTION_ACCESS>();
            this.ADM_USER = new HashSet<ADM_USER>();
            this.ADM_WEB_CONFIG = new HashSet<ADM_WEB_CONFIG>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SYS_CODE { get; set; }
        public string TYPE { get; set; }
        public string VALUE { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<ADM_FUNCTION_ACCESS> ADM_FUNCTION_ACCESS { get; set; }
        public virtual ICollection<ADM_USER> ADM_USER { get; set; }
        public virtual ICollection<ADM_WEB_CONFIG> ADM_WEB_CONFIG { get; set; }
    }
}
