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
    
    public partial class WallCartStory
    {
        public int WallCartStoryId { get; set; }
        public int StoryId { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string CurrencyCode { get; set; }
        public bool DeletedWallCartStory { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Catalogo Catalogo { get; set; }
        public virtual WallStory WallStory { get; set; }
    }
}
