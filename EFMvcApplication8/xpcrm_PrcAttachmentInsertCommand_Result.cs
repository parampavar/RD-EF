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
    
    public partial class xpcrm_PrcAttachmentInsertCommand_Result
    {
        public int Id { get; set; }
        public string LobNativeIdentifier { get; set; }
        public string Name { get; set; }
        public int AdmContentId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public string FileExtension { get; set; }
        public byte[] Content { get; set; }
        public byte[] ContextContent { get; set; }
        public int ParentId { get; set; }
        public short ParentKindId { get; set; }
        public short Status { get; set; }
        public Nullable<System.DateTime> StatusChangeDateTime { get; set; }
        public short DeleteFlag { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public System.DateTime SvrUpdateDateTime { get; set; }
        public int PerformByUserId { get; set; }
    }
}
