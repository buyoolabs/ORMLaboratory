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
    
    public partial class WallRebuyStory
    {
        public int WallRebuyStoryId { get; set; }
        public int StoryId { get; set; }
        public string Comment { get; set; }
        public int LinkedStoryId { get; set; }
        public string Links { get; set; }
    
        public virtual WallStory WallStory { get; set; }
        public virtual WallStory WallStory1 { get; set; }
    }
}
