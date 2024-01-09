
Console.WriteLine("## WHILE ##");


Console.WriteLine("Qual tabuada você quer obter? ");
var valor = Convert.ToInt32(Console.ReadLine());
var i = 1;
if(valor > 0)
{

    while(i < 11)
    {
        Console.WriteLine($"{valor} X  {i} = {valor* i}");
        i++;
    }

}
else
{
    Console.WriteLine("Opção invalida");
}
Console.ReadKey();
