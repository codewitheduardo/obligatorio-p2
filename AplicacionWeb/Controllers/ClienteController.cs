using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Perfil()
        {
            return View(this._sistema.ListarClientesEnUsuarios()[0]);
        }

        [HttpGet]
        public IActionResult Registro(string error)
        {
            ViewBag.Error = error;

            return View();
        }
    }
}
