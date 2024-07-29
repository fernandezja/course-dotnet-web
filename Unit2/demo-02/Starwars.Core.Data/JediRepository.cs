using Starwars.Core.Entities;

namespace Starwars.Core.Data
{
    public class JediRepository
    {
        public Jedi GetJedi(int jediId)
        {
            return new Jedi()
            {
                Name = "Obi-Wan Kenobi"
            };
        }
    }
}
