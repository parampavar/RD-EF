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
    
    public partial class AdmProcessServiceInsertCommand_Result
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public short KindId { get; set; }
        public short Sequence { get; set; }
        public string Name { get; set; }
        public short ServiceType { get; set; }
        public string ServiceUrl { get; set; }
        public string ActionUrl { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginDomain { get; set; }
        public byte[] XslToService { get; set; }
        public byte[] XslFromService { get; set; }
        public short PersistType { get; set; }
        public Nullable<int> ContentTypeId { get; set; }
        public System.DateTime EffectiveDateTime { get; set; }
        public Nullable<System.DateTime> ExpirationDateTime { get; set; }
        public System.DateTime SvrUpdateDateTime { get; set; }
        public int PerformByUserId { get; set; }
        public int DirtyState { get; set; }
    }
}
