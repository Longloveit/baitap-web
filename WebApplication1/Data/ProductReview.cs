using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class ProductReview
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public byte Rating { get; set; }

    public string? Title { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsApproved { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
