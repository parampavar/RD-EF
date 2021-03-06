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
    
    public partial class ADM_PROCESS_SERVICE
    {
        public int ID { get; set; }
        public int TYPE_ID { get; set; }
        public short KIND_ID { get; set; }
        public short SEQUENCE { get; set; }
        public string NAME { get; set; }
        public short SERVICE_TYPE { get; set; }
        public string SERVICE_URL { get; set; }
        public string ACTION_URL { get; set; }
        public string LOGIN_NAME { get; set; }
        public string LOGIN_PASSWORD { get; set; }
        public string LOGIN_DOMAIN { get; set; }
        public byte[] XSL_TO_SERVICE { get; set; }
        public byte[] XSL_FROM_SERVICE { get; set; }
        public short PERSIST_TYPE { get; set; }
        public Nullable<int> CONTENT_TYPE_ID { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_CONTENT_TYPE ADM_CONTENT_TYPE { get; set; }
        public virtual SYS_KIND SYS_KIND { get; set; }
    }
}
