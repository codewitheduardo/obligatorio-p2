using Dominio;
using Dominio.Ordenes;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class AdminController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Clientes()
        {
            List<Cliente> listaDeClientes = this._sistema.ListarClientesEnUsuarios();
            listaDeClientes.Sort(new OrdenUsuarioPorDocumento());

            return View(listaDeClientes);
        }
    }
}
