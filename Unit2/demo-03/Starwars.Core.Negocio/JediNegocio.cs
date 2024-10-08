using Starwars.Core.Datos;
using Starwars.Core.Entidades;

namespace Starwars.Core.Negocio
{
    public class JediNegocio
    {
        private readonly JediRepository _jediRepository;

        public JediNegocio()
        {
            _jediRepository = new JediRepository();
        }

        public List<Jedi> GetAll()
        {
            return _jediRepository.GetAll();
        }
    }
}
