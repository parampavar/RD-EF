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
    
    public partial class SYS_AUX_LIST_TYPE
    {
        public SYS_AUX_LIST_TYPE()
        {
            this.ADM_AUX_LIST = new HashSet<ADM_AUX_LIST>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CATEGORY { get; set; }
        public string FILTER1 { get; set; }
        public string FILTER2 { get; set; }
        public short HIDDEN_FLAG { get; set; }
        public System.DateTime INSERT_DATETIME { get; set; }
        public System.DateTime LAST_TOUCH_DATETIME { get; set; }
        public System.DateTime ACTIVATION_DATETIME { get; set; }
    
        public virtual ICollection<ADM_AUX_LIST> ADM_AUX_LIST { get; set; }
    }
}
