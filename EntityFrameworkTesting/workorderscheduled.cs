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
    
    public partial class workorderscheduled
    {
        public int TransactionID { get; set; }
        public int WorkOrderID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime ScheduleDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    }
}