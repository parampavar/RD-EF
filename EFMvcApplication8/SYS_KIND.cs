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
    
    public partial class SYS_KIND
    {
        public SYS_KIND()
        {
            this.ADM_ENTITY_TYPE_ACCESS = new HashSet<ADM_ENTITY_TYPE_ACCESS>();
            this.ADM_PROCESS_SERVICE = new HashSet<ADM_PROCESS_SERVICE>();
            this.PRC_ATTACHMENT = new HashSet<PRC_ATTACHMENT>();
            this.PRC_ATTACHMENT_REFERENCE = new HashSet<PRC_ATTACHMENT_REFERENCE>();
            this.PRC_LINK = new HashSet<PRC_LINK>();
            this.PRC_NOTE = new HashSet<PRC_NOTE>();
        }
    
        public short ID { get; set; }
        public string NAME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<ADM_ENTITY_TYPE_ACCESS> ADM_ENTITY_TYPE_ACCESS { get; set; }
        public virtual ICollection<ADM_PROCESS_SERVICE> ADM_PROCESS_SERVICE { get; set; }
        public virtual ICollection<PRC_ATTACHMENT> PRC_ATTACHMENT { get; set; }
        public virtual ICollection<PRC_ATTACHMENT_REFERENCE> PRC_ATTACHMENT_REFERENCE { get; set; }
        public virtual ICollection<PRC_LINK> PRC_LINK { get; set; }
        public virtual ICollection<PRC_NOTE> PRC_NOTE { get; set; }
    }
}
