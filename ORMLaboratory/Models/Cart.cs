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
    
    public partial class Cart
    {
        public int CartID { get; set; }
        public System.DateTime DateAdd { get; set; }
        public int CatalogID { get; set; }
        public int Quantity { get; set; }
        public int UserID { get; set; }
        public string GlobalUniqueIdentifier { get; set; }
    
        public virtual Catalogo Catalogo { get; set; }
        public virtual User User { get; set; }
    }
}