using Microsoft.AspNetCore.Mvc;

namespace Proj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
