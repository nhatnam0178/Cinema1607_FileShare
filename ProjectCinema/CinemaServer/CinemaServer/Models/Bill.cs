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
    
    public partial class Bill
    {
        public int ID { get; set; }
        public int ID_Ticket { get; set; }
        public int ID_Employee { get; set; }
        public int ID_UserAccount { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Total { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}