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
    
    public partial class xpcrm_AttachmentSelect_Result
    {
        public string AttachmentId { get; set; }
        public Nullable<int> AttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }
        public string Name { get; set; }
        public Nullable<int> Status { get; set; }
        public byte[] Content { get; set; }
        public string FileExtension { get; set; }
        public Nullable<int> OwnerUserId { get; set; }
        public Nullable<short> IsOwnedByCurrentUser { get; set; }
        public Nullable<short> IsEditable { get; set; }
        public Nullable<short> IsDeletable { get; set; }
    }
}
