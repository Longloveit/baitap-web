using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Banner
{
    public int BannerId { get; set; }

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? LinkUrl { get; set; }

    public string? Position { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTime? StartAt { get; set; }

    public DateTime? EndAt { get; set; }
}
