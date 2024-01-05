Console.WriteLine("Digite primeiro numero: ");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite segundo numero: ");
var num2 = int.Parse(Console.ReadLine());   
if(num1 > num2)
    Console.WriteLine("Numero 1 é maior que numero 2");
if (num1 < num2)
    Console.WriteLine("Numero 2 é maior que o numero 1 ");
if (num1 == num2)
    Console.WriteLine("Os dois numeros são iguais");

Console.ReadKey();
