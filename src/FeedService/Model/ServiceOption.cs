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
    
    public partial class ServiceOption
    {
        public int ServiceOptionId { get; set; }
        public string OptionCode { get; set; }
        public int AccountId { get; set; }
        public bool Active { get; set; }
        public System.DateTime EffectiveStartDateUtc { get; set; }
        public System.DateTime EffectiveEndDateUtc { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
