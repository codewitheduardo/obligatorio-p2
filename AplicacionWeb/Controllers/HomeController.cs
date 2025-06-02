using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
