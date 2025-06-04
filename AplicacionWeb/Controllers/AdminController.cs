using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
