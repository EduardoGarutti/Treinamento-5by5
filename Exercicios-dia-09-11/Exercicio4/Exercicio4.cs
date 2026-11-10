//4- Crie um programa que receba dois numeros e execute as 4 operações matematicas basicas.

Console.WriteLine("Informe dois numeros inteiros: ");
int numero1 = int.Parse(Console.ReadLine());
int numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;
int subtacao = numero1 - numero2;
int multiplicacao = numero1 * numero2;
int divisao = numero1 / numero2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtação: " + subtacao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);