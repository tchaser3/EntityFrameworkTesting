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
    
    public partial class purchaserequestitem
    {
        public int LineID { get; set; }
        public int PONumber { get; set; }
        public int LineQuantity { get; set; }
        public string VendorPartNumber { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<int> PartID { get; set; }
        public decimal PricePerUnit { get; set; }
        public int ItemTypeID { get; set; }
        public decimal TotalPrice { get; set; }
    }
}