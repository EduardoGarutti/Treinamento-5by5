//5 - Faça um programa que leia um numero inteiro e Exiba o seu calculo fatorial.

Console.WriteLine("Digite um numero inteiro: ");
int nmr = int.Parse(Console.ReadLine());

int aux = nmr;
int fatoracao = 1;
for (int i = 0; i < nmr; i++)
{
    fatoracao *= aux;
    aux--;
}

Console.WriteLine("Resultado fatorial: " + fatoracao);