using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Coupon
{
    public int CouponId { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public int? DiscountPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? MaxDiscountAmount { get; set; }

    public decimal MinOrderAmount { get; set; }

    public int Quantity { get; set; }

    public int UsedCount { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>();
}
