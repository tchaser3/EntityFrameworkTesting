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
    
    public partial class workorder
    {
        public int WorkOrderID { get; set; }
        public string WorkOrderNumber { get; set; }
        public int WorkTypeID { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public System.DateTime DateEntered { get; set; }
        public System.DateTime DateScheduled { get; set; }
        public System.DateTime DateReceived { get; set; }
        public System.DateTime StatusDate { get; set; }
        public int StatusID { get; set; }
    }
}
