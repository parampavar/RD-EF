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
    
    public partial class xpmed_KitDetails_Result
    {
        public string KitInstance { get; set; }
        public short VALIDATED_FLAG { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public string AssetTag { get; set; }
        public Nullable<int> Used { get; set; }
        public Nullable<int> Missing { get; set; }
        public int ExpiringCount { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<int> Recalled { get; set; }
        public Nullable<int> Halted { get; set; }
        public string Condition { get; set; }
        public short REPAIR_REQUIRED_FLAG { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int ExpiringInNintyDays { get; set; }
        public int ExpiringInSixtyDays { get; set; }
        public int ExpiringInThirtyDays { get; set; }
        public int Expired { get; set; }
        public string WarehouseName { get; set; }
        public int ID { get; set; }
        public Nullable<int> IsLatestKit { get; set; }
        public int IsKitHasSchedule { get; set; }
    }
}