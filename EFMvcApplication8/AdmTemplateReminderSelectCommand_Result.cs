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
    
    public partial class AdmTemplateReminderSelectCommand_Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public int ActivityTypeId { get; set; }
        public Nullable<int> ParentTemplateActionId { get; set; }
        public Nullable<int> InclusionRuleId { get; set; }
        public int OrgLevelId { get; set; }
        public short PlatformToApply { get; set; }
        public System.DateTime EffectiveDateTime { get; set; }
        public Nullable<System.DateTime> ExpirationDateTime { get; set; }
        public System.DateTime SvrUpdateDateTime { get; set; }
        public int PerformByUserId { get; set; }
        public int DirtyState { get; set; }
    }
}
