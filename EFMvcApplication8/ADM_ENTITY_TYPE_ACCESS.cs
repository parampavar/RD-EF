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
    
    public partial class ADM_ENTITY_TYPE_ACCESS
    {
        public int ENTITY_TYPE_ID { get; set; }
        public short ENTITY_KIND { get; set; }
        public int DIST_PROFILE_ID { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_DIST_PROFILE ADM_DIST_PROFILE { get; set; }
        public virtual SYS_KIND SYS_KIND { get; set; }
    }
}
