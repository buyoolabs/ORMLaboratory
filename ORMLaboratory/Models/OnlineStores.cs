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
    
    public partial class OnlineStores
    {
        public int OnlineStoreId { get; set; }
        public string OnlineStore { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
