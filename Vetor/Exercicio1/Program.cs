//1 - Faça um programa que leia até seis characteres e grave num vetor na ordem inserida.
//Imprima o vetor da primeira a ultima posição e da ultima a primeira posição

Console.WriteLine("Quantos characteres deseja inserir? (limite de 6)");
int qnt = int.Parse(Console.ReadLine());

while(entradaNaoValida(qnt))
{
    Console.WriteLine("Quantidade invalida! " +
        "Insira um numero inteiro entre 1 a 6");
    qnt = int.Parse(Console.ReadLine());
}

char[] input = new char[qnt];
input = preencherVetor(input,qnt);

Console.WriteLine("\nDa primeira a ultima posição: ");
imprimirVetor(input, false);

Console.WriteLine("\nDa ultima para a primeira posição: ");
imprimirVetor(input, true);

//------------------------------------------------------------------
bool entradaNaoValida(int qnt)
{
    if ( qnt > 6 || qnt <= 0)
    {
        return true;
    }
    return false;
}

char[] preencherVetor(char[] vetor, int tamanho)
{
    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine($"Informe o Char na posição {i}");
        vetor[i] = char.Parse(Console.ReadLine());
    }
    return vetor;
}
void imprimirVetor(char[] vetor, bool invertido) 
{
    if(invertido)
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write($"{input[i]} ");
        }
    } else
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{input[i]} ");
        }
    }
}

