using Starwars.Core.Datos;
using Starwars.Core.Entidades;
using System;

namespace Starwars.Core.Negocio
{
    public class StarwarsNegocio
    {
        private StarwarsDatos starwarsDatos;

        public StarwarsNegocio()
        {
            starwarsDatos = new StarwarsDatos();
        }

        public string Saludar(string sufix) {

            return starwarsDatos.Saludar(sufix);
        }

        public string Saludar(Jedi jedi)
        {
            return starwarsDatos.Saludar(jedi);
        }
    }
}
