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
    
    public partial class warehousetrailerinspection
    {
        public int InspectionID { get; set; }
        public int TrailerID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime InspectionDate { get; set; }
        public string InspectionStatus { get; set; }
        public int PartID { get; set; }
        public string ReelNumber { get; set; }
        public int CurrentFootage { get; set; }
        public string InspectionNotes { get; set; }
    }
}
