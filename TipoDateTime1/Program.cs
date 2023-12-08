Console.WriteLine("## Struct DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//criar uma data especifica usa formato: aaa, mm, dd
DateTime dataHoje = new DateTime(2022, 09, 09);
Console.WriteLine(dataHoje);

//definir as horas 
DateTime dataHoraHoje = new DateTime(2022, 09, 06 ,21, 10, 30);
Console.WriteLine(dataHoraHoje);

Console.ReadKey();
