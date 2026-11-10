//4 - Faça um programa que leia um numero inteiro e mostre todos os numeros primos até ele (inclusive ele, se for primo)

Console.WriteLine("Informe um numero inteiro: ");
int nmr = int.Parse(Console.ReadLine());

bool verificador;

for (int i = 2; i <= nmr; i++)
{
    verificador = true;

    for (int j = 2; j<i; j++)
    {
        if (i % j == 0)
        {
            verificador = false;
        }
    }

    if (verificador)
    {
        Console.Write(i + " ");
    }
}