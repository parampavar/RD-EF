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
    
    public partial class PRC_GPS
    {
        public int ID { get; set; }
        public string DEVICE { get; set; }
        public decimal LATITUDE { get; set; }
        public decimal LONGITUDE { get; set; }
        public short SATELLITE_COUNT { get; set; }
        public short POLL_INTERVAL { get; set; }
        public System.DateTime POLL_DATETIME { get; set; }
        public int SYNC_STATUS { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    }
}