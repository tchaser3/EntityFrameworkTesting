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
    
    public partial class purchaserequest
    {
        public int PONumber { get; set; }
        public System.DateTime RequestDate { get; set; }
        public System.DateTime RequiredDate { get; set; }
        public int RequestingEmployeeID { get; set; }
        public int DepartmentHeadID { get; set; }
        public int DepartmentID { get; set; }
        public int OfficeID { get; set; }
        public int VendorID { get; set; }
        public string RequestNotes { get; set; }
        public bool QuoteRequested { get; set; }
        public bool PurchaseRequested { get; set; }
        public bool RequestApproved { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public bool RequestDenied { get; set; }
        public Nullable<System.DateTime> DenialDate { get; set; }
        public string DenialNotes { get; set; }
        public string CurrentStatus { get; set; }
        public Nullable<System.DateTime> DateComplete { get; set; }
    }
}
