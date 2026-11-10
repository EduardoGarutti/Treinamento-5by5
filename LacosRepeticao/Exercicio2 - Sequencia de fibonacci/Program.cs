//2 - Faça um programa que leia um numero inteiro. Esse numero é a posição na qual a sequencia fibonacci será exibida.

Console.WriteLine("Informe o numero no qual a sequencia de fibonacci será exibida: ");
int nmr = int.Parse(Console.ReadLine());

int a = 1, b = 0, aux = a;

for  (int i = 0; i < nmr; i++)
{
    Console.Write(aux + " ");
    aux = a + b;
    b = a;
    a = aux;
}