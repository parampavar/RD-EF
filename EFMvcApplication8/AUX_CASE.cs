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
    
    public partial class AUX_CASE
    {
        public AUX_CASE()
        {
            this.AUX_CASE_PRODUCT = new HashSet<AUX_CASE_PRODUCT>();
            this.AUX_CASE_NOTE = new HashSet<AUX_CASE_NOTE>();
            this.AUX_CASE_PRODUCT_CONFLICT = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT1 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT2 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT3 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT4 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_INVENTORY_TRACK = new HashSet<AUX_INVENTORY_TRACK>();
            this.AUX_KIT_INSTANCE_TRACK = new HashSet<AUX_KIT_INSTANCE_TRACK>();
            this.AUX_PRODUCT_ORDER = new HashSet<AUX_PRODUCT_ORDER>();
        }
    
        public int ACTIVITY_ID { get; set; }
        public int TERRITORY_ID { get; set; }
        public short ACTIVITY_STATUS { get; set; }
        public Nullable<int> FACILITY_ID { get; set; }
        public string FACILITY_NAME { get; set; }
        public int OWNER_USER_ID { get; set; }
        public string PATIENT_NAME { get; set; }
        public string PATIENT_GENDER_LV { get; set; }
        public string PO { get; set; }
        public string PO_LIVE { get; set; }
        public string PO_REPLENISHMENT { get; set; }
        public short LIVE_CONSIGNMENT_FLAG { get; set; }
        public string SHIP_ADDRESS_TYPE { get; set; }
        public Nullable<int> SHIP_TO_ADDRESS_ID { get; set; }
        public string SHIP_ATTENTION { get; set; }
        public string SHIP_NOTE { get; set; }
        public string SHIP_INSTRUCTION_LV { get; set; }
        public string NOTE { get; set; }
        public string SOURCE { get; set; }
        public Nullable<System.DateTime> WORKED_ON_DATETIME { get; set; }
        public Nullable<short> NEXT_CASE_FLAG { get; set; }
        public int SYNC_STATUS { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<AUX_CASE_PRODUCT> AUX_CASE_PRODUCT { get; set; }
        public virtual AUX_POST_BILL AUX_POST_BILL { get; set; }
        public virtual MED_CASE MED_CASE { get; set; }
        public virtual AUX_FACILITY AUX_FACILITY { get; set; }
        public virtual ICollection<AUX_CASE_NOTE> AUX_CASE_NOTE { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT1 { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT2 { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT3 { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT4 { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY { get; set; }
        public virtual ICollection<AUX_INVENTORY_TRACK> AUX_INVENTORY_TRACK { get; set; }
        public virtual ICollection<AUX_KIT_INSTANCE_TRACK> AUX_KIT_INSTANCE_TRACK { get; set; }
        public virtual ICollection<AUX_PRODUCT_ORDER> AUX_PRODUCT_ORDER { get; set; }
        public virtual PRC_ACTIVITY PRC_ACTIVITY { get; set; }
    }
}
