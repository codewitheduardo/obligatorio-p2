using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        public IActionResult Index()
        {
            return View(this._sistema.ListarClientesEnUsuarios()[0]);
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}
