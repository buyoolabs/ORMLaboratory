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
    
    public partial class Invite
    {
        public int InviteID { get; set; }
        public System.DateTime InviteDate { get; set; }
        public int InvitePartner { get; set; }
        public int UserID { get; set; }
        public string SenderPartnerID { get; set; }
        public string SenderEmail { get; set; }
        public string RecipientPartnerID { get; set; }
        public string RecipientEmail { get; set; }
    
        public virtual User User { get; set; }
    }
}