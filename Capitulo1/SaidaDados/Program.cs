Console.WriteLine("SAIDA DE DADOS : FORMATAÇÃO");

int idade = 25;
string nome = "João";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

// escrever na mesma linha
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" ");
Console.WriteLine(" Anos");

//concatenação : usando operador +

Console.WriteLine(nome + " tem " + idade +" anos");

// usa interpolação de strings : $ -> a interpolação{} 
Console.WriteLine($"{nome} tem {idade} anos");

// usa place holders 
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();