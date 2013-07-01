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
    
    public partial class ADM_RULE
    {
        public ADM_RULE()
        {
            this.ADM_TEMPLATE_ACTION = new HashSet<ADM_TEMPLATE_ACTION>();
            this.ADM_TEMPLATE_ACTIVITY = new HashSet<ADM_TEMPLATE_ACTIVITY>();
            this.ADM_TEMPLATE_ATTACHMENT = new HashSet<ADM_TEMPLATE_ATTACHMENT>();
            this.ADM_TEMPLATE_ATTACHMENT1 = new HashSet<ADM_TEMPLATE_ATTACHMENT>();
            this.ADM_TEMPLATE_LINK = new HashSet<ADM_TEMPLATE_LINK>();
            this.ADM_TEMPLATE_REMINDER = new HashSet<ADM_TEMPLATE_REMINDER>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public byte[] XSL_TO_RESULT { get; set; }
        public short RULE_TYPE { get; set; }
        public System.DateTime EFFECTIVE_DATETIME { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<ADM_TEMPLATE_ACTION> ADM_TEMPLATE_ACTION { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ACTIVITY> ADM_TEMPLATE_ACTIVITY { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ATTACHMENT> ADM_TEMPLATE_ATTACHMENT { get; set; }
        public virtual ICollection<ADM_TEMPLATE_ATTACHMENT> ADM_TEMPLATE_ATTACHMENT1 { get; set; }
        public virtual ICollection<ADM_TEMPLATE_LINK> ADM_TEMPLATE_LINK { get; set; }
        public virtual ICollection<ADM_TEMPLATE_REMINDER> ADM_TEMPLATE_REMINDER { get; set; }
    }
}