using Starwars.Core.Entidades;
using SCE2 = Starwars.Core.Entidades; //alias de namespaces
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive
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

        public string Saludar2(SCE2.Jedi jedi)
        {
            return Saludar(jedi.Nombre);
        }
    }
}
