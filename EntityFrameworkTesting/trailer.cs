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
    
    public partial class trailer
    {
        public int TrailerID { get; set; }
        public string TrailerNumber { get; set; }
        public int CategoryID { get; set; }
        public string VINNumber { get; set; }
        public string TrailerDescription { get; set; }
        public string LicensePlate { get; set; }
        public int LocationID { get; set; }
        public int EmployeeID { get; set; }
        public bool TrailerActive { get; set; }
        public bool TrailerAvailable { get; set; }
        public string TrailerNotes { get; set; }
    }
}
