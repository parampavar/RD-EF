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
    
    public partial class xprpt_IntegrationFeedStatus_Result
    {
        public int ConfigId { get; set; }
        public short IsInboundFeed { get; set; }
        public string FeedName { get; set; }
        public string FeedFileName { get; set; }
        public string FeedStatus { get; set; }
        public string ProcessedDateTime { get; set; }
        public Nullable<int> TrailerRowCount { get; set; }
        public Nullable<int> TotalNoOfLines { get; set; }
        public int NoOfErroredLines { get; set; }
        public int NoOfRejectedLines { get; set; }
        public string ErrorFileName { get; set; }
        public string RejectFileName { get; set; }
        public string ArchiveFileName { get; set; }
        public string OutputFileName { get; set; }
        public string FeedDescription { get; set; }
    }
}
