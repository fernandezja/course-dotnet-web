using Starwars.Core.Entidades;
using System;

namespace Starwars.Core.Datos
{
    public class StarwarsDatos
    {
        public string Saludar(string sufix)
        {
            return $"Hola {sufix}!";
        }

        public string Saludar(Jedi jedi)
        {
            return Saludar(jedi.Nombre);
        }
    }
}
