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
    
    public partial class FSM_FEEDSERVICE_LOG
    {
        public int ID { get; set; }
        public int CONFIG_ID { get; set; }
        public string FILENAME { get; set; }
        public string STATUS_LV { get; set; }
        public Nullable<int> TRAILER_ROWCOUNT { get; set; }
        public Nullable<int> NUMBER_OF_LINES { get; set; }
        public Nullable<int> NUMBER_OF_ERROR_LINES { get; set; }
        public Nullable<int> NUMBER_OF_REJECT_LINES { get; set; }
        public string FILENAME_ERROR { get; set; }
        public string FILENAME_REJECT { get; set; }
        public string FILENAME_ARCHIVE { get; set; }
        public string FILENAME_OUTPUT { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
    
        public virtual FSM_FEEDSERVICE_CONFIG FSM_FEEDSERVICE_CONFIG { get; set; }
    }
}
