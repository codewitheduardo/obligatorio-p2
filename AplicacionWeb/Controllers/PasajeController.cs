using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class PasajeController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Comprar(string id, DateTime fecha, Equipaje equipaje)
        {
            try
            {
                Vuelo vuelo = this._sistema.ObtenerVuelo(id);
                this._sistema.EmitirPasaje(vuelo, fecha, equipaje);
                return RedirectToAction("Index", "Vuelos", new { mensaje = $"Pasaje reservado para el vuelo {vuelo.Numero} el {fecha.ToString("dd MMM yyyy")}" });
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Vuelos", new { error = e.Message });
            }
        }
    }
}
