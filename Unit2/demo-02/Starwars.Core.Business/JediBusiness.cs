using Starwars.Core.Entities;
using Starwars.Core.Data;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {
        public Jedi GetJedi(int jediId)
        {
            var jediRepository = new JediRepository();


            return jediRepository.GetJedi(jediId);
        }
    }
}
