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
    
    public partial class AUX_CASE_TYPE
    {
        public int ID { get; set; }
        public int ACTIVITY_TYPE_ID { get; set; }
        public int LINE_ID { get; set; }
        public short SEQUENCE { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_ACTIVITY_TYPE ADM_ACTIVITY_TYPE { get; set; }
        public virtual AUX_PRODUCT_LINE AUX_PRODUCT_LINE { get; set; }
    }
}
