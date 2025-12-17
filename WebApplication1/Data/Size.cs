using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Size
{
    public int SizeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
