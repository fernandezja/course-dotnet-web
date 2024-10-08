// See https://aka.ms/new-console-template for more information
using System;



var jedi = new Starwars.Core.Entidades.Jedi() { 
    JediId = 1,
    Name = "Luke Skywalker"
};

Console.WriteLine(Starwars.Core.Comun.ComunHelper.Saludar(jedi.Name));

var jediNegocio = new Starwars.Core.Negocio.JediNegocio();
var jedis = jediNegocio.GetAll();
foreach (var j in jedis)
{
    Console.WriteLine(Starwars.Core.Comun.ComunHelper.Saludar(j.Name));
}