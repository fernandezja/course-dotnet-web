using System.Diagnostics;

namespace Starwars.Core.Entidades
{
    public class Jedi
    {
        public int JediId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string PlanetaNatal { get; set; }

        

        public override string ToString()
        {
            return $"{JediId} - {Nombre} ({Especie}) - {PlanetaNatal}";
        }

    }
}
