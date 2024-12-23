// See https://aka.ms/new-console-template for more information
using Starwars.Core.Negocio;
using System.Text;

var demo = new System.DateTime();


Console.WriteLine("Hello, World!");

var jediNegocio = new JediNegocio();

var jedis = jediNegocio.ObtenerTodos();

foreach (var jedi in jedis)
{
    Console.WriteLine($">> {jedi}");
}

//Cualquier.Cosa.Class1 c = new Cualquier.Cosa.Class1();  

Console.ReadKey();