//1 - Faça um programa que leia até seis characteres e grave num vetor na ordem inserida.
//Imprima o vetor da primeira a ultima posição e da ultima a primeira posição

Console.WriteLine("Quantos characteres deseja inserir? (limite de 6)");
int qnt = int.Parse(Console.ReadLine());

while(qnt > 6 || qnt <= 0)
{
    Console.WriteLine("Quantidade invalida! " +
        "Insira um numero inteiro entre 1 a 6");
    qnt = int.Parse(Console.ReadLine());
}

char[] input = new char[qnt];

for(int i=0; i < qnt; i++)
{
    Console.WriteLine($"Informe o Char na posição {i}");
    input[i] = char.Parse(Console.ReadLine());
}

Console.WriteLine("\nDa primeira a ultima posição: ");
for(int i = 0; i < qnt; i++)
{
    Console.Write($"{input[i]} ");
}

Console.WriteLine("\nDa ultima para a primeira posição: ");
for(int i = qnt-1; i >= 0; i--)
{
    Console.Write($"{input[i]} ");
}
