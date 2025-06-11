using AplicacionWeb.Filters;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    [Authentication]
    public class ClienteController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Perfil()
        {
            return View(this._sistema.ObtenerCliente(HttpContext.Session.GetString("documento")));
        }

        [HttpGet]
        public IActionResult Registro(string error)
        {
            ViewBag.Error = error;

            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string password, string documento, string nombre, string nacionalidad)
        {
            try
            {
                this._sistema.AltaClienteOcasional(correo, password, documento, nombre, nacionalidad);

                return RedirectToAction("Index", "Home", new { mensaje = $"El cliente con el documento {documento} se registró correctamente." });
            }
            catch (Exception e)
            {
                return RedirectToAction("Registro", "Cliente", new { error = e.Message });
            }
        }

        [HttpGet]
        
        public IActionResult Login()
        {
            return View();
        }
    }
}
