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
    
    public partial class PaymentMethod
    {
        public int Id { get; set; }
        public string type { get; set; }
        public Nullable<int> CVV { get; set; }
        public Nullable<bool> Default { get; set; }
        public Nullable<int> CustID { get; set; }
    
        public virtual User User { get; set; }
    }
}
