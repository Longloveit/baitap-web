using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();

        }
    }
}
