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
    
    public partial class PRC_CONTACT_MAP
    {
        public int CONTACT_ID { get; set; }
        public int USER_ID { get; set; }
        public string CONTACT_OID { get; set; }
        public string CONTACT_ENTRY_ID { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_USER ADM_USER { get; set; }
        public virtual PRC_CONTACT PRC_CONTACT { get; set; }
    }
}