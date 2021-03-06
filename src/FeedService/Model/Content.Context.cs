﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ContentEntities : DbContext
    {
        public ContentEntities()
            : base("name=ContentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionItem> SubscriptionItems { get; set; }
    
        public virtual ObjectResult<usp_SearchFeedItems_Result> usp_SearchFeedItems(Nullable<int> accountId, Nullable<int> subscriptionId, string searchPattern, Nullable<int> returnCount)
        {
            var accountIdParameter = accountId.HasValue ?
                new ObjectParameter("accountId", accountId) :
                new ObjectParameter("accountId", typeof(int));
    
            var subscriptionIdParameter = subscriptionId.HasValue ?
                new ObjectParameter("subscriptionId", subscriptionId) :
                new ObjectParameter("subscriptionId", typeof(int));
    
            var searchPatternParameter = searchPattern != null ?
                new ObjectParameter("searchPattern", searchPattern) :
                new ObjectParameter("searchPattern", typeof(string));
    
            var returnCountParameter = returnCount.HasValue ?
                new ObjectParameter("returnCount", returnCount) :
                new ObjectParameter("returnCount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SearchFeedItems_Result>("usp_SearchFeedItems", accountIdParameter, subscriptionIdParameter, searchPatternParameter, returnCountParameter);
        }
    }
}
