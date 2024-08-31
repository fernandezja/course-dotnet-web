// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Starwars.Core.Business;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

//Init: Config
var configuration = new ConfigurationBuilder()
                        .AddJsonFile($"appSettings.json");

var config = configuration.Build();

var title1 = config["Title"];
var title2 = config.GetSection("Title");

var connectionString1 = config.GetSection("ConnectionStrings:StarwarsConnectionString");


var connectionString = config.GetConnectionString("StarwarsConnectionString");

var starwarsConfig = new StarwarsConfig();
starwarsConfig.StarwarsConnectionString = connectionString;


Console.WriteLine("Stawars!");

PrintLine();

var jediBusiness = new JediBusiness(starwarsConfig);

var jedis1 = jediBusiness.GetAll();

Console.WriteLine($"[GetAll] Jedis Total = {jedis1.Count()}");


foreach (var j in jedis1)
{
    Console.WriteLine($" |_ {j.Name}");
}


PrintLine();


//var filter = new JediFilter() { 
//                Name = "0001" 
//             };

//var jedis2 = jediBusiness.Search(filter);

//Console.WriteLine($"[Search] Jedis with a name contain \"0001\" Total = {jedis2.Count()}");

//foreach (var j in jedis2)
//{
//    Console.WriteLine($" |_ {j.Name}");
//}

PrintLine();


//var jedis3 = jediBusiness.SearchWithStoreProcedure(filter);

//Console.WriteLine($"[SearchWithStoreProcedure] Jedis with a name contain \"0001\" Total = {jedis3.Count()}");

//foreach (var j in jedis3)
//{
//    Console.WriteLine($" |_ {j.Name}");
//}

PrintLine();



Console.WriteLine("Press any key to continue..");
Console.ReadKey();


void PrintLine()
{
    Console.WriteLine();
    Console.WriteLine($"----------------------------------------------------------------------");
    Console.WriteLine();
}