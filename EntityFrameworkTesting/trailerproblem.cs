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
    
    public partial class trailerproblem
    {
        public int ProblemID { get; set; }
        public int TrailerID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int EmployeeID { get; set; }
        public string ProblemReported { get; set; }
        public decimal ProblemCost { get; set; }
        public bool ProblemSolved { get; set; }
        public int VendorID { get; set; }
    }
}