Console.WriteLine("Opedores de Atribuição");

Console.WriteLine("Infome a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resultado}");




Console.ReadKey();