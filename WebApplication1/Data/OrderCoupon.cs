using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class OrderCoupon
{
    public int OrderId { get; set; }

    public int CouponId { get; set; }

    public decimal DiscountAmount { get; set; }

    public virtual Coupon Coupon { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
