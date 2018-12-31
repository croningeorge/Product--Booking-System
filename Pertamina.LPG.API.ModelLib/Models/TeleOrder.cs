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
    
    public partial class TeleOrder
    {
        public TeleOrder()
        {
            this.TeleCustomers = new HashSet<TeleCustomer>();
            this.TeleOrderDeliveries = new HashSet<TeleOrderDelivery>();
            this.TeleOrderDetails = new HashSet<TeleOrderDetail>();
            this.TeleOrderPrdocuctExchanges = new HashSet<TeleOrderPrdocuctExchange>();
        }
    
        public int TeleOrdID { get; set; }
        public int AgadmID { get; set; }
        public Nullable<int> DrvrID { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.TimeSpan OrderTime { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<short> DeliverySlotID { get; set; }
        public int NumberOfProducts { get; set; }
        public decimal SubTotal { get; set; }
        public Nullable<decimal> PromoProduct { get; set; }
        public Nullable<decimal> ShippingCharge { get; set; }
        public Nullable<decimal> PromoShipping { get; set; }
        public decimal GrantTotal { get; set; }
        public bool DeliveryType { get; set; }
        public Nullable<System.DateTime> DeliveryStartDate { get; set; }
        public Nullable<System.DateTime> DeliveredDate { get; set; }
        public int Deviation { get; set; }
        public short StatusId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public decimal RefillSubTotal { get; set; }
        public decimal PromoRefill { get; set; }
        public decimal ExchangeSubTotal { get; set; }
        public decimal PromoExchange { get; set; }
    
        public virtual AgentAdmin AgentAdmin { get; set; }
        public virtual AgentAdmin AgentAdmin1 { get; set; }
        public virtual AgentAdmin AgentAdmin2 { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual MDeliverySlot MDeliverySlot { get; set; }
        public virtual MOrderStatu MOrderStatu { get; set; }
        public virtual ICollection<TeleCustomer> TeleCustomers { get; set; }
        public virtual ICollection<TeleOrderDelivery> TeleOrderDeliveries { get; set; }
        public virtual ICollection<TeleOrderDetail> TeleOrderDetails { get; set; }
        public virtual ICollection<TeleOrderPrdocuctExchange> TeleOrderPrdocuctExchanges { get; set; }
    }
}