// See https://aka.ms/new-console-template for more information
using Starwars.Core.Entities;

Console.WriteLine("Hello, World!");



var jediBusiness = new Starwars.Core.Business.JediBusiness();
var jedi = jediBusiness.GetJedi(10);

Console.WriteLine($"Jedi: {jedi.Name}");

