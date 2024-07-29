using Starwars.Core.Negocio;
using System;

namespace Starwars.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console APP NET 8");

            var negocio = new StarwarsNegocio();
            var saludo = negocio.Saludar("Yoda");


            Console.WriteLine($"{saludo}");
            Console.WriteLine(saludo);
            Console.ReadKey();


        }
    }
}
