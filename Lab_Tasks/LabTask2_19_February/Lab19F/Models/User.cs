//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab19F.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserOrders = new HashSet<UserOrder>();
        }
    
        public int Uid { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
