
Console.WriteLine("Instrução While");

int x = 0;
while (x < 5) ;
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"{x},{y}");
        y++;
    }
    x++;
    Console.WriteLine();
}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();