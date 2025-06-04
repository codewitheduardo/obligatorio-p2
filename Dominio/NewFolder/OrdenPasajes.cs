using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.NewFolder
{
    public class OrdenPasajes : IComparer<Pasaje>
    {
        public int Compare(Pasaje? este, Pasaje? otro)
        {
            return este.Fecha.CompareTo(otro.Fecha) * -1;
        }
    }
}
