using Starwars.Core.Entidades;

namespace Starwars.Core.Datos
{
    public class JediRepository
    {
        public List<Jedi> GetAll() { 

            var jedis = new List<Jedi>();
            for (int i = 1; i <= 10; i++)
            {
                jedis.Add(new Jedi() { JediId = i, Name = $"Jedi {i}" });
            }
            return jedis;
        }
    }
}
