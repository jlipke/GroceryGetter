//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroceryGetter.PL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAisle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAisle()
        {
            this.tblAisleProducts = new HashSet<tblAisleProduct>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid LayoutId { get; set; }
        public string Number { get; set; }
        public int Lineup { get; set; }
    
        public virtual tblLayout tblLayout { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAisleProduct> tblAisleProducts { get; set; }
    }
}
