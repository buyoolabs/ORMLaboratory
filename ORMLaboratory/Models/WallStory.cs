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
    
    public partial class WallStory
    {
        public WallStory()
        {
            this.Notifications = new HashSet<Notifications>();
            this.WallAttachmentStory = new HashSet<WallAttachmentStory>();
            this.WallCartStory = new HashSet<WallCartStory>();
            this.WallCommentStory = new HashSet<WallCommentStory>();
            this.WallLikeStory = new HashSet<WallLikeStory>();
            this.WallOwnStory = new HashSet<WallOwnStory>();
            this.WallOwnStory1 = new HashSet<WallOwnStory>();
            this.WallRebuyStory = new HashSet<WallRebuyStory>();
            this.WallRebuyStory1 = new HashSet<WallRebuyStory>();
            this.WallRecommendedStory = new HashSet<WallRecommendedStory>();
            this.WallRecommendedStory1 = new HashSet<WallRecommendedStory>();
            this.WallShareStory = new HashSet<WallShareStory>();
            this.WallShareStory1 = new HashSet<WallShareStory>();
            this.WallShareStory2 = new HashSet<WallShareStory>();
            this.WallStory_Gender = new HashSet<WallStory_Gender>();
            this.WallStory1 = new HashSet<WallStory>();
            this.WallStoryTag = new HashSet<WallStoryTag>();
            this.WallTradeStory = new HashSet<WallTradeStory>();
            this.WallWishStory = new HashSet<WallWishStory>();
            this.AgeRank = new HashSet<AgeRank>();
            this.Category = new HashSet<Category>();
            this.Color = new HashSet<Color>();
            this.Pyramid = new HashSet<Pyramid>();
            this.Season = new HashSet<Season>();
            this.Tribe = new HashSet<Tribe>();
        }
    
        public int StoryId { get; set; }
        public int TypeId { get; set; }
        public Nullable<int> StoryParentId { get; set; }
        public int OwnerId { get; set; }
        public int NumLike { get; set; }
        public int NumWish { get; set; }
        public bool isPrivate { get; set; }
        public System.DateTime Date { get; set; }
        public bool Deleted { get; set; }
        public Nullable<int> PublishSource { get; set; }
        public string TagBrand { get; set; }
        public string TagModel { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<System.DateTime> DateBackendReview { get; set; }
        public bool Reviewed { get; set; }
        public Nullable<bool> isPhotoOk { get; set; }
        public string Recognition_en { get; set; }
        public string Recognition_es { get; set; }
        public string RecognitionStepName { get; set; }
        public string CompleteText_en { get; set; }
        public string CompleteText_es { get; set; }
    
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<WallAttachmentStory> WallAttachmentStory { get; set; }
        public virtual ICollection<WallCartStory> WallCartStory { get; set; }
        public virtual ICollection<WallCommentStory> WallCommentStory { get; set; }
        public virtual ICollection<WallLikeStory> WallLikeStory { get; set; }
        public virtual ICollection<WallOwnStory> WallOwnStory { get; set; }
        public virtual ICollection<WallOwnStory> WallOwnStory1 { get; set; }
        public virtual ICollection<WallRebuyStory> WallRebuyStory { get; set; }
        public virtual ICollection<WallRebuyStory> WallRebuyStory1 { get; set; }
        public virtual ICollection<WallRecommendedStory> WallRecommendedStory { get; set; }
        public virtual ICollection<WallRecommendedStory> WallRecommendedStory1 { get; set; }
        public virtual ICollection<WallShareStory> WallShareStory { get; set; }
        public virtual ICollection<WallShareStory> WallShareStory1 { get; set; }
        public virtual ICollection<WallShareStory> WallShareStory2 { get; set; }
        public virtual ICollection<WallStory_Gender> WallStory_Gender { get; set; }
        public virtual ICollection<WallStory> WallStory1 { get; set; }
        public virtual WallStory WallStory2 { get; set; }
        public virtual WallTypeStory WallTypeStory { get; set; }
        public virtual ICollection<WallStoryTag> WallStoryTag { get; set; }
        public virtual ICollection<WallTradeStory> WallTradeStory { get; set; }
        public virtual ICollection<WallWishStory> WallWishStory { get; set; }
        public virtual ICollection<AgeRank> AgeRank { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Color> Color { get; set; }
        public virtual ICollection<Pyramid> Pyramid { get; set; }
        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<Tribe> Tribe { get; set; }
    }
}
