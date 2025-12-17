using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly TmdtContext _context;

    public HomeController(TmdtContext context)
    {
        _context = context;
    }

   

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult _NewArrivals()
    {
        return View();

    }
    public IActionResult _ExploreProducts()
    {

        return View();
    }
    public IActionResult _BestSellingProducts()
    {
        return View();

    }
    public IActionResult _BrowseByCategory()
    {
        return View();

    }
    public IActionResult _FlashSales()
    {
        return View();

    }
    public async Task<IActionResult> Index()
    {
        var now = DateTime.UtcNow;
        // Lấy danh mục cấp 1 (bên trái màn hình)
        var categories = await _context.Categories
            .Where(c => c.IsActive && c.ParentId == null)
            .OrderBy(c => c.DisplayOrder)
            .ToListAsync();

        // Lấy flash sale đang active
        var flashSale = await _context.FlashSales
            .Include(f => f.FlashSaleProducts)
                .ThenInclude(fp => fp.Product)
            .Where(f => f.IsActive && f.StartAt <= now && f.EndAt >= now)
            .OrderBy(f => f.StartAt)
            .FirstOrDefaultAsync();

        // Lấy list product trong flash sale (lấy 4 cái giống UI)
        var flashProducts = flashSale?.FlashSaleProducts
            .Select(fp => fp.Product)
            .Take(4)
            .ToList() ?? new List<Product>();

        ViewBag.FlashSaleProducts = flashProducts;
        ViewBag.FlashSaleEnd = flashSale?.EndAt;
     

        // TRUYỀN thẳng List<Category> xuống view
        return View(categories);
    }
    public IActionResult _Wishlist()
    {
        return View();

    }
    public IActionResult _Cart()
    {
        return View();

    }
    public IActionResult _CheckOut()
    {
        return View();

    }
    public IActionResult _MyAccount()
    {
        return View();

    }
    public IActionResult _About()
    {
        return View();

    }
    public IActionResult _Contact()
    {
        return View();

    }


    public IActionResult _NotFound()
    {
        return View();

    }
    public IActionResult _Detail()
    {
        return View();

    }
    public IActionResult _Banner()
    {
        return View();

    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
   
  
    // Action test DB
   
}
