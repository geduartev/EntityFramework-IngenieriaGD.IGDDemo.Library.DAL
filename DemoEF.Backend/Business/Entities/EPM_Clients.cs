//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoEF.Backend.Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class EPM_Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EPM_Clients()
        {
            this.EPM_Deliveries = new HashSet<EPM_Deliveries>();
        }
    
        public int Id { get; set; }
        public string Phone { get; set; }
        public int LastRead { get; set; }
        public bool Readed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EPM_Deliveries> EPM_Deliveries { get; set; }
    }
}
