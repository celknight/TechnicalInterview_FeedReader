//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeedService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscriptionItem
    {
        public int SubscriptionItemId { get; set; }
        public int SubscriptionId { get; set; }
        public System.DateTime ExpirationDateUtc { get; set; }
        public string Content { get; set; }
        public string ItemId { get; set; }
        public System.DateTime PublishedDateUtc { get; set; }
    
        public virtual Subscription Subscription { get; set; }
    }
}
