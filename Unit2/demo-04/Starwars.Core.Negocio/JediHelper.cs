using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Negocio
{
    public static class JediHelper
    {
        public static string ObtenerNombreJedi(int id)
        {
            // Aquí puedes implementar la lógica para obtener el nombre del Jedi según su ID.
            // Por simplicidad, devolveremos un nombre ficticio.
            return $"Jedi con ID {id}";
        }

    }
}
