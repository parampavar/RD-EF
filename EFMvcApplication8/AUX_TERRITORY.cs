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
    
    public partial class AUX_TERRITORY
    {
        public AUX_TERRITORY()
        {
            this.AUX_BIN = new HashSet<AUX_BIN>();
            this.AUX_CASE = new HashSet<AUX_CASE>();
            this.AUX_CASE_PRODUCT = new HashSet<AUX_CASE_PRODUCT>();
            this.AUX_KIT = new HashSet<AUX_KIT>();
            this.AUX_KIT_INSTANCE = new HashSet<AUX_KIT_INSTANCE>();
            this.AUX_KIT_INSTANCE1 = new HashSet<AUX_KIT_INSTANCE>();
            this.AUX_KIT_TEMPLATE = new HashSet<AUX_KIT_TEMPLATE>();
            this.AUX_PRODUCT_LINE = new HashSet<AUX_PRODUCT_LINE>();
            this.AUX_PRODUCT_ORDER = new HashSet<AUX_PRODUCT_ORDER>();
            this.AUX_PRODUCT_ORDER1 = new HashSet<AUX_PRODUCT_ORDER>();
            this.AUX_REGION = new HashSet<AUX_REGION>();
            this.AUX_USER = new HashSet<AUX_USER>();
            this.AUX_WAREHOUSE = new HashSet<AUX_WAREHOUSE>();
        }
    
        public int ID { get; set; }
        public int COMPANY_ID { get; set; }
        public string TYPE_LV { get; set; }
        public string NAME { get; set; }
        public string IDENTIFIER { get; set; }
        public string ACCOUNT_NUMBER { get; set; }
        public string BILL_TO_NUMBER { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string POSTAL_CODE { get; set; }
        public string COUNTRY { get; set; }
        public string PHONE { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public short DELETE_FLAG { get; set; }
        public Nullable<System.DateTime> DELETE_DATETIME { get; set; }
        public short TEST_FLAG { get; set; }
        public short INTEGRATION_FLAG { get; set; }
        public string ADDITIONAL_VALUES_XML { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public Nullable<System.DateTime> SVR_INSERT_DATETIME { get; set; }
        public Nullable<System.DateTime> SVR_UPDATE_DATETIME { get; set; }
        public Nullable<int> PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<AUX_BIN> AUX_BIN { get; set; }
        public virtual ICollection<AUX_CASE> AUX_CASE { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT> AUX_CASE_PRODUCT { get; set; }
        public virtual AUX_COMPANY AUX_COMPANY { get; set; }
        public virtual ICollection<AUX_KIT> AUX_KIT { get; set; }
        public virtual ICollection<AUX_KIT_INSTANCE> AUX_KIT_INSTANCE { get; set; }
        public virtual ICollection<AUX_KIT_INSTANCE> AUX_KIT_INSTANCE1 { get; set; }
        public virtual ICollection<AUX_KIT_TEMPLATE> AUX_KIT_TEMPLATE { get; set; }
        public virtual ICollection<AUX_PRODUCT_LINE> AUX_PRODUCT_LINE { get; set; }
        public virtual ICollection<AUX_PRODUCT_ORDER> AUX_PRODUCT_ORDER { get; set; }
        public virtual ICollection<AUX_PRODUCT_ORDER> AUX_PRODUCT_ORDER1 { get; set; }
        public virtual ICollection<AUX_REGION> AUX_REGION { get; set; }
        public virtual ICollection<AUX_USER> AUX_USER { get; set; }
        public virtual ICollection<AUX_WAREHOUSE> AUX_WAREHOUSE { get; set; }
    }
}