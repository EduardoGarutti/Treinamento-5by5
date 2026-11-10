//1- Escreva um programa que receba um numero inteiro e informe se ele é par ou impar

Console.WriteLine("Informe um numero: ");
int numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine("O numero informado é par");
} else
{
    Console.WriteLine("O numero informado é impar");
}

