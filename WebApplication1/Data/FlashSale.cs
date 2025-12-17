using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class FlashSale
{
    public int FlashSaleId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartAt { get; set; }

    public DateTime EndAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<FlashSaleProduct> FlashSaleProducts { get; set; } = new List<FlashSaleProduct>();
}
