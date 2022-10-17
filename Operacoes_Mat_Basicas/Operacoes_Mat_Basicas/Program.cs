
using Operacoes_Mat_Basicas.Operacoes;

Console.WriteLine("Olá, Boas Vindas ao Calculatrix!");

Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(10, 10));
Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Calcular(10,10));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(10,10));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(10,10));

Console.ReadKey();
