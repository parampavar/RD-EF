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
    
    public partial class AUX_KIT_INSTANCE
    {
        public AUX_KIT_INSTANCE()
        {
            this.AUX_CASE_PRODUCT = new HashSet<AUX_CASE_PRODUCT>();
            this.AUX_CASE_PRODUCT_CONFLICT = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT1 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT2 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_CASE_PRODUCT_CONFLICT3 = new HashSet<AUX_CASE_PRODUCT_CONFLICT>();
            this.AUX_KIT_INSTANCE_PRODUCT = new HashSet<AUX_KIT_INSTANCE_PRODUCT>();
            this.AUX_KIT_INSTANCE_TRACK = new HashSet<AUX_KIT_INSTANCE_TRACK>();
        }
    
        public int ID { get; set; }
        public int HOME_TERRITORY_ID { get; set; }
        public int CURRENT_TERRITORY_ID { get; set; }
        public int KIT_ID { get; set; }
        public string NAME { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public string STATE_LV { get; set; }
        public string LOCATION_LV { get; set; }
        public string CONDITION_LV { get; set; }
        public short REPAIR_REQUIRED_FLAG { get; set; }
        public short VALIDATED_FLAG { get; set; }
        public string STATUS_LV { get; set; }
        public Nullable<int> LOCATION_ID { get; set; }
        public int HOME_WAREHOUSE_ID { get; set; }
        public int CURRENT_WAREHOUSE_ID { get; set; }
        public string ASSET_TAG { get; set; }
        public short DELETE_FLAG { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public string PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<AUX_CASE_PRODUCT> AUX_CASE_PRODUCT { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT1 { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT2 { get; set; }
        public virtual ICollection<AUX_CASE_PRODUCT_CONFLICT> AUX_CASE_PRODUCT_CONFLICT3 { get; set; }
        public virtual AUX_KIT AUX_KIT { get; set; }
        public virtual ICollection<AUX_KIT_INSTANCE_PRODUCT> AUX_KIT_INSTANCE_PRODUCT { get; set; }
        public virtual AUX_WAREHOUSE AUX_WAREHOUSE { get; set; }
        public virtual AUX_WAREHOUSE AUX_WAREHOUSE1 { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY1 { get; set; }
        public virtual ICollection<AUX_KIT_INSTANCE_TRACK> AUX_KIT_INSTANCE_TRACK { get; set; }
    }
}