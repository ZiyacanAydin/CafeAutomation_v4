//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeAutomation_v3.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales()
        {
            this.Kasa = new HashSet<Kasa>();
        }
    
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TableId { get; set; }
        public System.DateTime DateTime { get; set; }
        public int count { get; set; }
        public decimal Sum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa> Kasa { get; set; }
        public virtual Product Product { get; set; }
        public virtual Table Table { get; set; }
    }
}