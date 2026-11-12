
using System.Security.Cryptography;

const int linha = 3;
const int coluna = 4;

int[,] matriz = new int[linha, coluna];

PreencherMatriz(matriz);

int[,] matrizInvertida = GerarNovaMatrizInvertida(matriz);
int[,] matrizEspelhada = GerarNovaMatrizEspelhada(matriz);

Console.WriteLine("\nMatriz normal:");
ExibirMatriz(matriz);

Console.WriteLine("\nMatriz invertida:");
ExibirMatriz(matrizInvertida);

Console.WriteLine("\nMatriz espelhada:");
ExibirMatriz(matrizEspelhada);

void PreencherMatriz(int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        }
    }
}

int[,] GerarNovaMatrizInvertida(int[,] matriz)
{
    int[,] novaMatriz = new int[linha, coluna];

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            novaMatriz[i, j] = matriz[linha - 1 - i, coluna - 1 - j];
        }
    }

    return novaMatriz;
}

int[,] GerarNovaMatrizEspelhada(int[,] matriz)
{
    int[,] novaMatriz = new int[linha, coluna];

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            novaMatriz[i, j] = matriz[i, coluna - 1 - j];
        }
    }

    return novaMatriz;
}

void ExibirMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"[{i}][{j}] = {matriz[i, j]} ");
        }

        Console.WriteLine();
    }
}
