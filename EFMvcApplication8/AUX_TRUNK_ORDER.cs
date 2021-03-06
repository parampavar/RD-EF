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
    
    public partial class AUX_TRUNK_ORDER
    {
        public AUX_TRUNK_ORDER()
        {
            this.AUX_TRUNK_ORDER_PRODUCT = new HashSet<AUX_TRUNK_ORDER_PRODUCT>();
        }
    
        public int ID { get; set; }
        public int ATTACHMENT_ID { get; set; }
        public int USER_ID { get; set; }
        public short RUSH_FLAG { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATETIME { get; set; }
        public string AUTHORIZATION_NUMBER { get; set; }
        public string SHIP_ADDRESS_TYPE { get; set; }
        public Nullable<int> SHIP_TO_ADDRESS_ID { get; set; }
        public string SHIP_ATTENTION { get; set; }
        public string SHIP_NOTE { get; set; }
        public string SHIP_INSTRUCTION_LV { get; set; }
        public string FAX_TO { get; set; }
        public string EMAIL_TO { get; set; }
        public string EMAIL_BODY { get; set; }
        public short SUBMITTED_FLAG { get; set; }
        public int SYNC_STATUS { get; set; }
        public short DELETE_FLAG { get; set; }
        public Nullable<System.DateTime> DELETE_DATETIME { get; set; }
        public string SOURCE { get; set; }
        public Nullable<System.DateTime> WORKED_ON_DATETIME { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ADM_USER ADM_USER { get; set; }
        public virtual ICollection<AUX_TRUNK_ORDER_PRODUCT> AUX_TRUNK_ORDER_PRODUCT { get; set; }
        public virtual MED_TRUNK_ORDER MED_TRUNK_ORDER { get; set; }
        public virtual PRC_ATTACHMENT PRC_ATTACHMENT { get; set; }
    }
}
