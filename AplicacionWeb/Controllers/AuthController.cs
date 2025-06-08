using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class AuthController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpPost]
        public IActionResult Registro(string correo, string password, string documento, string nombre, string nacionalidad)
        {
            try
            {
                this._sistema.AltaClienteOcasional(correo, password, documento, nombre, nacionalidad);

                return RedirectToAction("Index", "Vuelo", new { mensaje = $"El cliente con el documento {documento} se registró correctamente." });
            }
            catch (Exception e)
            {
                return RedirectToAction("Registro", "Cliente", new { error = e.Message });
            }
        }
    }
}
