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
    
    public partial class ADM_ORG_LEVEL
    {
        public ADM_ORG_LEVEL()
        {
            this.ADM_ORG_LEVEL1 = new HashSet<ADM_ORG_LEVEL>();
            this.ADM_TEMPLATE_ACTION = new HashSet<ADM_TEMPLATE_ACTION>();
            this.ADM_TEMPLATE_ACTIVITY = new HashSet<ADM_TEMPLATE_ACTIVITY>();
            this.ADM_TEMPLATE_ATTACHMENT = new HashSet<ADM_TEMPLATE_ATTACHMENT>();
            this.ADM_TEMPLATE_LINK = new HashSet<ADM_TEMPLATE_LINK>();
            this.ADM_TEMPLATE_REMINDER = new HashSet<ADM_TEMPLATE_REMINDER>();
            this.ADM_USER = new HashSet<ADM_USER>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> PARENT_ORG_LEVEL_ID { get; set; }
        public int ORG_LEVEL_TYPE_ID { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual SYS_ORG_LEVEL_TYPE SYS_ORG_LEVEL_TYPE { get; set; }
        public virtual ICollection<ADM_ORG_LEVEL> ADM_ORG_LEVEL1 { get; set; }
        public virtual ADM_ORG_LEVEL ADM_ORG_LEVEL2 { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ACTION> ADM_TEMPLATE_ACTION { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ACTIVITY> ADM_TEMPLATE_ACTIVITY { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ATTACHMENT> ADM_TEMPLATE_ATTACHMENT { get; set; }
        public virtual ICollection<ADM_TEMPLATE_LINK> ADM_TEMPLATE_LINK { get; set; }
        public virtual ICollection<ADM_TEMPLATE_REMINDER> ADM_TEMPLATE_REMINDER { get; set; }
        public virtual ICollection<ADM_USER> ADM_USER { get; set; }
    }
}
