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
    
    public partial class MED_MESSAGE_QUEUE
    {
        public int ID { get; set; }
        public Nullable<int> OBJECT_ID { get; set; }
        public string BUSINESS_OBJECT { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string STATUS { get; set; }
        public string TO_LINE { get; set; }
        public string FAX_TO { get; set; }
        public string FROM_LINE { get; set; }
        public string SUBJECT_LINE { get; set; }
        public string MSG_BODY { get; set; }
        public Nullable<System.DateTime> INSERT_DATETIME { get; set; }
        public Nullable<System.DateTime> UPDATE_DATETIME { get; set; }
        public System.DateTime SVR_INSERT_DATETIME { get; set; }
        public System.DateTime SVR_UPDATE_DATETIME { get; set; }
        public int PERFORM_BY_USER_ID { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    }
}