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
    
    public partial class PRC_ATTACHMENT_REFERENCE
    {
        public int ID { get; set; }
        public int PARENT_ID { get; set; }
        public short PARENT_KIND_ID { get; set; }
        public int ADM_CONTENT_ID { get; set; }
        public string NAME { get; set; }
        public int CUSTOMER_ID { get; set; }
        public Nullable<int> ACTIVITY_ID { get; set; }
        public string FILE_EXTENSION { get; set; }
        public short DELETE_FLAG { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_CONTENT ADM_CONTENT { get; set; }
        public virtual PRC_ACTIVITY PRC_ACTIVITY { get; set; }
        public virtual SYS_KIND SYS_KIND { get; set; }
        public virtual PRC_CUSTOMER PRC_CUSTOMER { get; set; }
    }
}
