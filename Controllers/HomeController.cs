using Microsoft.AspNetCore.Mvc;

namespace cybershoppromowebpage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}