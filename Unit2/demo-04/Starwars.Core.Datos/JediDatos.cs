using Starwars.Core.Entidades;

namespace Starwars.Core.Datos;

    public class JediDatos
    {
        public List<Jedi> ObtenerTodos()
        {
            var jedis = new List<Jedi>
            {
                new Jedi { JediId = 1, Nombre = "Luke Skywalker", Especie = "Humano", PlanetaNatal = "Tatooine" },
                new Jedi { JediId = 2, Nombre = "Yoda", Especie = "Desconocida", PlanetaNatal = "Desconocido" },
                new Jedi { JediId = 3, Nombre = "Obi-Wan Kenobi", Especie = "Humano", PlanetaNatal = "Stewjon" },
                new Jedi { JediId = 4, Nombre = "Mace Windu", Especie = "Humano", PlanetaNatal = "Haruun Kal" },
                new Jedi { JediId = 5, Nombre = "Qui-Gon Jinn", Especie = "Humano", PlanetaNatal = "Coruscant" },
                new Jedi { JediId = 6, Nombre = "Ki-Adi-Mundi", Especie = "Cereano", PlanetaNatal = "Cerea" }
            };

            return jedis; 
        }
    }

