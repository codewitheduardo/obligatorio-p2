using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class VuelosController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;
        public IActionResult Index(string mensaje)
        {
            ViewBag.Mensaje = mensaje;
            return View(this._sistema.Vuelos);
        }

        [HttpGet]
        public IActionResult Buscar(string codSalida, string codLlegada)
        {
            if (string.IsNullOrWhiteSpace(codSalida) && string.IsNullOrWhiteSpace(codLlegada))
            {
                return RedirectToAction("Index", new { mensaje = "Debe ingresar al menos un código de aeropuerto para buscar." });
            }

            List<Vuelo> vuelosFiltrados = this._sistema.ListarVuelosPorAeropuertos(codSalida, codLlegada);

            if (vuelosFiltrados.Count == 0)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontraron vuelos con los datos ingresados." });
            }

            return View("Index", vuelosFiltrados);
        }

        public IActionResult Detalle()
        {
            return View();
        }
    }
}
