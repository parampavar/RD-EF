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
    
    public partial class MED_FACILITY_DEPARTMENT
    {
        public int ID { get; set; }
        public int FACILITY_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string IDENTIFIER { get; set; }
        public string HEALTH_INDUSTRY_NUMBER { get; set; }
        public Nullable<short> DISCOUNT_RATE { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORMED_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual AUX_FACILITY AUX_FACILITY { get; set; }
    }
}