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
    
    public partial class vehicleinspectionproblem
    {
        public int TransactionID { get; set; }
        public int VehicleID { get; set; }
        public int InspectionID { get; set; }
        public string InspectionType { get; set; }
        public string VehicleProblem { get; set; }
        public int OdometerReading { get; set; }
        public bool VehicleServiceability { get; set; }
        public string InspectionNotes { get; set; }
        public string ManagerNotes { get; set; }
        public string FleetEmployeeNotes { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public Nullable<int> FleetEmployeeID { get; set; }
        public Nullable<int> ProblemID { get; set; }
    }
}
