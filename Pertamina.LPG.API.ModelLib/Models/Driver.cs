//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pertamina.LPG.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        public Driver()
        {
            this.ConsumerReviews = new HashSet<ConsumerReview>();
            this.Orders = new HashSet<Order>();
            this.OrderDeliveries = new HashSet<OrderDelivery>();
            this.TeleOrders = new HashSet<TeleOrder>();
            this.TeleOrderDeliveries = new HashSet<TeleOrderDelivery>();
        }
    
        public int DrvrID { get; set; }
        public string DriverName { get; set; }
        public int AgenID { get; set; }
        public int DbptID { get; set; }
        public string MobileNumber { get; set; }
        public bool StatusId { get; set; }
        public short CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public short UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string AccToken { get; set; }
        public string AppID { get; set; }
        public string AppToken { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public string ProfileImage { get; set; }
        public string Password { get; set; }
    
        public virtual Agency Agency { get; set; }
        public virtual ICollection<ConsumerReview> ConsumerReviews { get; set; }
        public virtual DistributionPoint DistributionPoint { get; set; }
        public virtual SuperAdmin SuperAdmin { get; set; }
        public virtual SuperAdmin SuperAdmin1 { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        public virtual ICollection<TeleOrder> TeleOrders { get; set; }
        public virtual ICollection<TeleOrderDelivery> TeleOrderDeliveries { get; set; }
    }
}