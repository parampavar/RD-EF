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
    
    public partial class ExcMessageQueueInsertCommand_Result
    {
        public int Id { get; set; }
        public int ToUserId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public short MessageStatus { get; set; }
        public Nullable<System.DateTime> ProcessDateTime { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public System.DateTime SvrUpdateDateTime { get; set; }
        public int PerformByUserId { get; set; }
    }
}
