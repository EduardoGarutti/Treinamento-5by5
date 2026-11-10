//1 - Faça um programa que leia um numero inteiro e mostre a tabuada de 1 a 10

Console.WriteLine("informe um numero: ");
int nmr = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " X " + nmr+ " = " +(nmr*i));
}