//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class FurloughDetailModel
    {
        public System.Guid FurloughId { get; set; }
        public System.DateTime DayOff { get; set; }
        public double NumberDay { get; set; }
        public string TypeDate { get; set; }
        public Nullable<bool> Del { get; set; }
        public Nullable<System.Guid> DelAccountId { get; set; }
        public Nullable<System.DateTime> DelTime { get; set; }
        public string Note { get; set; }
    
        public virtual FurloughModel FurloughModel { get; set; }
    }
}