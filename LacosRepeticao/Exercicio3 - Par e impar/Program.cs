//3 - Faça um programa que leia um numero inteiro e mostre primeiramente apenas os valores impares (na ordem crescente)
//e depois os valores pares (na ordem decrescente)

Console.WriteLine("Informe um numero inteiro");
int nmr = int.Parse(Console.ReadLine());

Console.WriteLine("Impares na ordem crescente: ");
for(int i = 1; i<=nmr; i +=2)
{
    Console.Write(i + " ");
}

Console.WriteLine("\nPares na ordem decrescente: ");
for (int i = nmr; i > 0; i -= 2)
{
    Console.Write(i + " ");
}