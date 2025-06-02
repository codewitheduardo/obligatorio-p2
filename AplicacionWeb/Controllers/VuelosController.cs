using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class VuelosController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;
        public IActionResult Index()
        {
            return View(this._sistema.Vuelos);
        }

        [HttpGet]
        public IActionResult Buscar(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return View(new List<Vuelo>());
            }

            List<Vuelo> vuelosFiltrados = this._sistema.ListarVuelosPorAeropuerto(codigo);

            if (vuelosFiltrados.Count == 0)
            {
                ViewBag.MensajeSinResultados = "No se encontraron vuelos con los datos ingresados.";
            }

            return View(vuelosFiltrados);
        }
    }
}
