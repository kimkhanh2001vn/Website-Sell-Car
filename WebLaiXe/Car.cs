//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebLaiXe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarDetails = new HashSet<CarDetail>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Nullable<int> IdCategory { get; set; }
        public Nullable<int> Place { get; set; }
        public string Images { get; set; }
        public string Brand { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual CarCategory CarCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarDetail> CarDetails { get; set; }
    }
}
