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
    
    public partial class tool
    {
        public int ToolKey { get; set; }
        public string ToolID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string PartNumber { get; set; }
        public int CategoryID { get; set; }
        public string ToolDescription { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal ToolCost { get; set; }
        public bool Available { get; set; }
        public bool ToolActive { get; set; }
        public int CurrentLocation { get; set; }
        public string ToolNotes { get; set; }
    }
}