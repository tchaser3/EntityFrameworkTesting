//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkTesting
{
    using System;
    using System.Collections.Generic;
    
    public partial class assignedtask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assignedtask()
        {
            this.assignedemployeetasks = new HashSet<assignedemployeetask>();
        }
    
        public int TransactionID { get; set; }
        public int OriginatingEmployeeID { get; set; }
        public System.DateTime AssignedDate { get; set; }
        public System.DateTime CompletedDate { get; set; }
        public string MessageSubject { get; set; }
        public string MessageText { get; set; }
        public bool TaskComplete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assignedemployeetask> assignedemployeetasks { get; set; }
        public virtual employee employee { get; set; }
    }
}
