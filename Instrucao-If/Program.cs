Console.WriteLine("Crie uma senha");
var senha = Console.ReadLine();

Console.WriteLine("Entre com a senha criada");
var resp = Console.ReadLine();

if(resp != senha)
    Console.WriteLine("Senha incorreta");
if(resp == senha)
    Console.WriteLine("Entrou..");


Console.ReadKey();
