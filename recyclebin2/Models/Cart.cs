//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace recyclebin2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int CartID { get; set; }
        public int CatagoryID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
    
        public virtual Catagory Catagory { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
