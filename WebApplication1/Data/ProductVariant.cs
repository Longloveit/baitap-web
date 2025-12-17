using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class ProductVariant
{
    public int VariantId { get; set; }

    public int ProductId { get; set; }

    public int? ColorId { get; set; }

    public int? SizeId { get; set; }

    public string? Sku { get; set; }

    public decimal Price { get; set; }

    public decimal? OldPrice { get; set; }

    public int StockQuantity { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Color? Color { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product Product { get; set; } = null!;

    public virtual Size? Size { get; set; }
}
