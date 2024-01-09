namespace GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Digite até qua numero você quer contar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            
        repetir:
            Console.WriteLine($"i = {i}");
            i = +i + 2;
            
            if(i <= valor)
            {
                goto repetir;
                
                
            }
            Console.WriteLine("Fim do processamento..");
        }
    }
}