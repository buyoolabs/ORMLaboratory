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
    
    public partial class Groupon
    {
        public Groupon()
        {
            this.Transaccion = new HashSet<Transaccion>();
        }
    
        public byte IDGroupon { get; set; }
        public string DescripGroupon { get; set; }
    
        public virtual ICollection<Transaccion> Transaccion { get; set; }
    }
}
