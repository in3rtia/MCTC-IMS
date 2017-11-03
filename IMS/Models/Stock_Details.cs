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
    using System.Collections.Generic;
    
    public partial class Stock_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock_Details()
        {
            this.Movements = new HashSet<Movement>();
            this.Request_Details = new HashSet<Request_Details>();
            this.Stock_Withdraw = new HashSet<Stock_Withdraw>();
        }
    
        public int id { get; set; }
        public string stock_code { get; set; }
        public int quantity_available { get; set; }
        public string unit_of_withdraw { get; set; }
        public string description_of_items { get; set; }
        public string unit_of_issue { get; set; }
        public Nullable<int> reorder_level { get; set; }
        public Nullable<int> minimum_level { get; set; }
        public System.DateTime date_of_order { get; set; }
        public Nullable<System.DateTime> expiry_date { get; set; }
        public string stock_type { get; set; }
        public string compartment_ID { get; set; }
        public string category_ID { get; set; }
        public Nullable<int> availability { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movement> Movements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request_Details> Request_Details { get; set; }
        public virtual Shelf_Compartment Shelf_Compartment { get; set; }
        public virtual Stock_Availability Stock_Availability { get; set; }
        public virtual Stock_Category Stock_Category { get; set; }
        public virtual Stock_Type Stock_Type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Withdraw> Stock_Withdraw { get; set; }
    }
}
