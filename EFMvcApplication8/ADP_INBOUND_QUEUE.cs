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
    
    public partial class ADP_INBOUND_QUEUE
    {
        public string ENDPOINT_SYSTEM { get; set; }
        public short COMPONENT_KIND { get; set; }
        public string LOB_IDENTIFIER { get; set; }
        public string SYS_CODE { get; set; }
        public string LOB_SYS_CODE { get; set; }
        public string CUSTOMER_IDENTIFIER { get; set; }
        public string ACTIVITY_IDENTIFIER { get; set; }
        public byte[] ENDPOINT_CACHE { get; set; }
        public short PROCESS_STATUS { get; set; }
        public System.DateTime UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    }
}
