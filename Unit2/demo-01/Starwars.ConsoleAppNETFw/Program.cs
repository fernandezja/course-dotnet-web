using Starwars.Core.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.ConsoleAppNETFw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console APP NET Framework");

            var negocio = new StarwarsNegocio();
            var saludo = negocio.Saludar("Yoda");


            Console.WriteLine($"{saludo}");
            Console.WriteLine(saludo);
            Console.ReadKey();
        }
    }
}
