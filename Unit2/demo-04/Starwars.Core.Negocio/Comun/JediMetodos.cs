using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Negocio.Comun
{
    public static class JediMetodos
    {

        public static string FormatearNombreAMayusculas(string nombre)
        {
            return nombre.ToUpper();
        }
    }
}
