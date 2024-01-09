namespace Instrucao_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno");
            var notaAluno = int.Parse(Console.ReadLine());
           

            if(notaAluno < 5)
            {
                Console.WriteLine("Aluno REPROVADO");
            }
            else if(notaAluno > 5 && notaAluno < 7)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else if(notaAluno >= 7 && notaAluno <= 9)
            {
                Console.WriteLine("Aluno APROVADO");
            }
            else
            {
                Console.WriteLine("APROVADO COM DISTINÇÃO");
            }

        }
    }
}