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
    
    public partial class WallRecommendedStory
    {
        public int WallRecommendedStoryId { get; set; }
        public int UserId { get; set; }
        public int StoryId { get; set; }
        public int LinkedStoryId { get; set; }
    
        public virtual User User { get; set; }
        public virtual WallStory WallStory { get; set; }
        public virtual WallStory WallStory1 { get; set; }
    }
}
