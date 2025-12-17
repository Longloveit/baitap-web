using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class FlashSaleProduct
{
    public int FlashSaleId { get; set; }

    public int ProductId { get; set; }

    public decimal? SpecialPrice { get; set; }

    public virtual FlashSale FlashSale { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
