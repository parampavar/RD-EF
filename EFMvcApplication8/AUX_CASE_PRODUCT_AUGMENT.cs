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
    
    public partial class AUX_CASE_PRODUCT_AUGMENT
    {
        public int ID { get; set; }
        public int CASE_PRODUCT_ID { get; set; }
        public int KIT_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int QTY { get; set; }
        public string STATUS_LV { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual AUX_CASE_PRODUCT AUX_CASE_PRODUCT { get; set; }
        public virtual AUX_KIT AUX_KIT { get; set; }
        public virtual AUX_PRODUCT AUX_PRODUCT { get; set; }
    }
}
