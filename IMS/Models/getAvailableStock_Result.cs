//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS.Models
{
    using System;
    
    public partial class getAvailableStock_Result
    {
        public string stock_code { get; set; }
        public string description_of_items { get; set; }
        public int quantity_available { get; set; }
        public string unit_of_issue { get; set; }
        public string stock_type { get; set; }
        public Nullable<System.DateTime> expiry_date { get; set; }
        public string compartment_ID { get; set; }
        public string shelf { get; set; }
        public string stock_category { get; set; }
        public string status { get; set; }
    }
}
