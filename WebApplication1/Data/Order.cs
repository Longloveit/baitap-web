using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Order
{
    public int OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int UserId { get; set; }

    public int AddressId { get; set; }

    public DateTime CreatedAt { get; set; }

    public byte Status { get; set; }

    public byte PaymentMethod { get; set; }

    public byte PaymentStatus { get; set; }

    public decimal Subtotal { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal ShippingFee { get; set; }

    public decimal TaxFee { get; set; }

    public decimal GrandTotal { get; set; }

    public string? Note { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual User User { get; set; } = null!;
}
