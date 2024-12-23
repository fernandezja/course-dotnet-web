using Starwars.Core.Datos;
using Starwars.Core.Entidades;

namespace Starwars.Core.Negocio
{
    public class JediNegocio    
    {



       public List<Jedi> ObtenerTodos()
       {
            var jediDatos = new JediDatos();

            return jediDatos.ObtenerTodos();

        }
    }
}
