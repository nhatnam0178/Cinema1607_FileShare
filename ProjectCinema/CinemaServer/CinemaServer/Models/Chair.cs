//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chair()
        {
            this.ChairTickets = new HashSet<ChairTicket>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int ID_Room { get; set; }
    
        public virtual Room Room { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChairTicket> ChairTickets { get; set; }
    }
}
