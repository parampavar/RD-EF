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
    
    public partial class ADM_TEMPLATE_LINK
    {
        public int ID { get; set; }
        public string DESCRIPTION { get; set; }
        public int LINK_ID { get; set; }
        public int ACTIVITY_TYPE_ID { get; set; }
        public Nullable<int> PARENT_TEMPLATE_ACTION_ID { get; set; }
        public Nullable<int> INCLUSION_RULE_ID { get; set; }
        public int ORG_LEVEL_ID { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_ACTIVITY_TYPE ADM_ACTIVITY_TYPE { get; set; }
        public virtual ADM_LINK ADM_LINK { get; set; }
        public virtual ADM_ORG_LEVEL ADM_ORG_LEVEL { get; set; }
        public virtual ADM_RULE ADM_RULE { get; set; }
        public virtual ADM_TEMPLATE_ACTION ADM_TEMPLATE_ACTION { get; set; }
    }
}
