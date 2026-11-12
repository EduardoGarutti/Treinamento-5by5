using System.Security.Cryptography;

int tamanho = 10;
int[] vetor = new int[tamanho];

for(int i = 0; i < tamanho; i++)
{
    vetor[i] = RandomNumberGenerator.GetInt32(0, 10);
    Console.Write($"[{vetor[i]}]");
}

int aux1 = 0;
int aux2;

Console.WriteLine();
for(int contador = 1; contador !=0;)
{
    contador = 0;
    for(int j=0; j< vetor.Length-1; j++)
    {
        if(vetor[j] > vetor[j + 1])
        {
            aux2 = vetor[j+1];
            vetor[j + 1] = vetor[j];
            vetor[j] = aux2;
            contador++;
            aux1++;
        }
    }
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write($"[{vetor[i]}]");
}