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
    
    public partial class adjustinventory
    {
        public int TransactionID { get; set; }
        public int PartID { get; set; }
        public int Quantity { get; set; }
        public string Explanation { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int WarehouseID { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
