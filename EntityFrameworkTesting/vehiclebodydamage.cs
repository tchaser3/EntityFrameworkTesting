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
    
    public partial class vehiclebodydamage
    {
        public int TransactionID { get; set; }
        public int VehicleID { get; set; }
        public string BodyDamage { get; set; }
        public System.DateTime DateReported { get; set; }
        public bool Repaired { get; set; }
    }
}
