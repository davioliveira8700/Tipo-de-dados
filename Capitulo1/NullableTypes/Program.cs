Console.WriteLine("Nullable types");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

//Sintaxe alternativa

int? a = null;
double? c = null;
bool? n = null;
Console.WriteLine(a);
Console.WriteLine(c);
Console.WriteLine(n);

int? z = 100;
if (z.HasValue)
{
    Console.WriteLine($"z = {z.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}


Console.ReadKey();