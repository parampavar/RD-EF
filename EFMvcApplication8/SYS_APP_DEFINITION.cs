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
    
    public partial class SYS_APP_DEFINITION
    {
        public SYS_APP_DEFINITION()
        {
            this.EXC_ERROR_LOG = new HashSet<EXC_ERROR_LOG>();
            this.EXC_LOGIN_LOG = new HashSet<EXC_LOGIN_LOG>();
            this.SYS_APP_FUNCTION = new HashSet<SYS_APP_FUNCTION>();
            this.SYS_RESOURCE_STRING = new HashSet<SYS_RESOURCE_STRING>();
            this.SYS_WEB_CONFIG = new HashSet<SYS_WEB_CONFIG>();
        }
    
        public short ID { get; set; }
        public string NAME { get; set; }
        public short CONCURRENT_EXEC_FLAG { get; set; }
        public string METADATA { get; set; }
        public string APP_VERSION { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<EXC_ERROR_LOG> EXC_ERROR_LOG { get; set; }
        public virtual ICollection<EXC_LOGIN_LOG> EXC_LOGIN_LOG { get; set; }
        public virtual ICollection<SYS_APP_FUNCTION> SYS_APP_FUNCTION { get; set; }
        public virtual ICollection<SYS_RESOURCE_STRING> SYS_RESOURCE_STRING { get; set; }
        public virtual ICollection<SYS_WEB_CONFIG> SYS_WEB_CONFIG { get; set; }
    }
}
