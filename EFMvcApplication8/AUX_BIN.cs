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
    
    public partial class AUX_BIN
    {
        public AUX_BIN()
        {
            this.AUX_BIN_PRODUCT = new HashSet<AUX_BIN_PRODUCT>();
        }
    
        public int ID { get; set; }
        public int TERRITORY_ID { get; set; }
        public string NAME { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public int WAREHOUSE_ID { get; set; }
        public string TYPE_LV { get; set; }
        public string ASSET_TAG { get; set; }
        public string SHELF_TAG { get; set; }
        public string STATUS_LV { get; set; }
        public short DELETE_FLAG { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<AUX_BIN_PRODUCT> AUX_BIN_PRODUCT { get; set; }
        public virtual AUX_TERRITORY AUX_TERRITORY { get; set; }
        public virtual AUX_WAREHOUSE AUX_WAREHOUSE { get; set; }
    }
}
