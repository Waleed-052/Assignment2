using Microsoft.AspNetCore.Mvc;

namespace Proj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Men()
        {
            return View();
        }
        public IActionResult Women()
        {
            return View();
        }
        public IActionResult information()
        {
            return View();
        }
        public IActionResult Helpcenter()
        {
            return View();
        }
        public IActionResult Eventz()
        {
            return View();
        }
    }
}
