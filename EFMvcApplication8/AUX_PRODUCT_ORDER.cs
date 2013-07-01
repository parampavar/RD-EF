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
    
    public partial class AUX_PRODUCT_ORDER
    {
        public AUX_PRODUCT_ORDER()
        {
            this.AUX_PRODUCT_ORDER_PART = new HashSet<AUX_PRODUCT_ORDER_PART>();
        }
    
        public int ID { get; set; }
        public int TERRITORY_ID { get; set; }
        public Nullable<int> TO_TERRITORY_ID { get; set; }
        public Nullable<int> CASE_ID { get; set; }
        public string ORDER_NAME { get; set; }
        public string ORDER_NUMBER { get; set; }
        public System.DateTime ORDER_DATE { get; set; }
        public Nullable<int> WAREHOUSE_ID { get; set; }
        public Nullable<int> TO_WAREHOUSE_ID { get; set; }
        public string SHIP_TO_METHOD_LV { get; set; }
        public string BACKORDER_SHIP_TO_METHOD_LV { get; set; }
        public Nullable<int> SHIP_TO_ADDRESS_ID { get; set; }
        public string REQUEST_STATUS_LV { get; set; }
        public string PROCESS_STATUS_LV { get; set; }
        public string TYPE_LV { get; set; }
        public int REQUESTED_BY_USER_ID { get; set; }
        public string ADDITIONAL_VALUES_XML { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_USER ADM_USER { get; set; }
        public virtual AUX_CASE AUX_CASE { get; set; }
        public virtual ICollection<AUX_PRODUCT_ORDER_PART> AUX_PRODUCT_ORDER_PART { get; set; }
        public virtual AUX_SHIP_TO_ADDRESS AUX_SHIP_TO_ADDRESS { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY1 { get; set; }
        public virtual AUX_WAREHOUSE AUX_WAREHOUSE { get; set; }
        public virtual AUX_WAREHOUSE AUX_WAREHOUSE1 { get; set; }
    }
}