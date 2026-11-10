// 5- Faça um programa que leia o ano informado pelo usuario e mostre se é ou foi um ano bissexto

Console.WriteLine("Informe um ano no formato YYYY");
int ano = int.Parse(Console.ReadLine());

if(ano % 4 == 0 && !(ano % 100 == 0))
{
    Console.WriteLine("É um ano bissexto!");
} else if(ano % 400 == 0)
{
    Console.WriteLine("É um ano bissexto!");
} else
{
    Console.WriteLine("Não é um ano bissexto!");
}