using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public int? BrandId { get; set; }

    public string Name { get; set; } = null!;

    public string? Slug { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? OldPrice { get; set; }

    public int StockQuantity { get; set; }

    public string? ThumbnailImageUrl { get; set; }

    public int? DiscountPercent { get; set; }

    public double RatingAverage { get; set; }

    public int ReviewCount { get; set; }

    public bool IsFeatured { get; set; }

    public bool IsNew { get; set; }

    public bool IsFlashSale { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<FlashSaleProduct> FlashSaleProducts { get; set; } = new List<FlashSaleProduct>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

    public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
}
