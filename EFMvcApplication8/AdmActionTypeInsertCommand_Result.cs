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
    
    public partial class AdmActionTypeInsertCommand_Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SysCode { get; set; }
        public Nullable<int> LobId { get; set; }
        public double Duration { get; set; }
        public short Priority { get; set; }
        public short DistributionParentOverride { get; set; }
        public int Weight { get; set; }
        public Nullable<double> AgingDuration { get; set; }
        public System.DateTime EffectiveDateTime { get; set; }
        public Nullable<System.DateTime> ExpirationDateTime { get; set; }
        public int PerformByUserId { get; set; }
        public System.DateTime SvrUpdateDateTime { get; set; }
        public int DirtyState { get; set; }
    }
}
