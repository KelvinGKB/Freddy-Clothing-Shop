//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAssigment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promo
    {
        public int Id { get; set; }
        public double DiscountPercentage { get; set; }
        public Nullable<System.DateTime> ExpitedDate { get; set; }
        public Nullable<System.DateTime> RedeemTimes { get; set; }
        public string Condition { get; set; }
    }
}
