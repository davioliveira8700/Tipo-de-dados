Console.WriteLine("Estruturas Switch-Case");

int compra = 600;
Console.WriteLine("O valor da compra R$ 600,00");
Console.WriteLine("Informe o numero de parcelas de (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R${compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R${compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Valor invalido, informe 1, 2 ou 3");
        break;
        
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
