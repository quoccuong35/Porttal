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
    
    public partial class DepartmentCategory
    {
        public System.Guid DepartmentCategoryID { get; set; }
        public string DepartmentCategoryCode { get; set; }
        public string DepartmentCategoryName { get; set; }
        public Nullable<bool> Actived { get; set; }
        public string Description { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string LastModifiedUser { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
        public Nullable<int> OrderIndex { get; set; }
    }
}