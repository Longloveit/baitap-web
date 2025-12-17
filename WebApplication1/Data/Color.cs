using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Color
{
    public int ColorId { get; set; }

    public string Name { get; set; } = null!;

    public string? HexCode { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
