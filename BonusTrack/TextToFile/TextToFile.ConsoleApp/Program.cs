// See https://aka.ms/new-console-template for more information
using TextToFile.ConsoleApp;

Console.WriteLine("Hello, World!");

var textToFileCustom = new TextToFileCustom();
var archivoPath = "starwars-phrases.txt";

textToFileCustom.WriteTxt("The Force is strong with you! (App)",
             archivoPath);


Console.ReadKey();