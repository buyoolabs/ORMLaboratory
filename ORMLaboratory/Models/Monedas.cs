//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMLaboratory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monedas
    {
        public Monedas()
        {
            this.Order = new HashSet<Order>();
            this.Transaccion = new HashSet<Transaccion>();
            this.User = new HashSet<User>();
        }
    
        public string CodMoneda { get; set; }
        public string DescripcionMoneda { get; set; }
        public string SimboloMoneda { get; set; }
        public string Language { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Transaccion> Transaccion { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
