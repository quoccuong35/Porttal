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
    
    public partial class WorkPlace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkPlace()
        {
            this.EmployeeModels = new HashSet<EmployeeModel>();
        }
    
        public System.Guid WorkPlaceID { get; set; }
        public string WorkPlaceName { get; set; }
        public Nullable<int> OrderIndex { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Actived { get; set; }
        public Nullable<System.Guid> CreatedAccountId { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.Guid> LastModifiedAccountId { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeModel> EmployeeModels { get; set; }
    }
}
