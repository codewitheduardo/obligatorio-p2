using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Ordenes
{
    public class OrdenUsuarioPorDocumento : IComparer<Usuario>
    {
        public int Compare(Usuario? x, Usuario? y)
        {
            Cliente clienteX = x as Cliente;
            Cliente clienteY = y as Cliente;

            return clienteX.Documento.CompareTo(clienteY.Documento);
        }
    }
}
