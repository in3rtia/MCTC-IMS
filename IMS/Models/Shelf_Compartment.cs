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
    
    public partial class Shelf_Compartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shelf_Compartment()
        {
            this.Stock_Details = new HashSet<Stock_Details>();
            this.Stock_Withdraw = new HashSet<Stock_Withdraw>();
        }
    
        public int id { get; set; }
        public string compartment_ID { get; set; }
        public string shelf_ID { get; set; }
    
        public virtual Shelves_Table Shelves_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Details> Stock_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Withdraw> Stock_Withdraw { get; set; }
    }
}