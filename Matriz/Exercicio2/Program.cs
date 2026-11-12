//2 - Faça um programa que gere uma matriz 3x5 populada automaticamente e baseada nela gere uma nova matriz inversa.

using System.Security.Cryptography;

const int linha = 3;
const int coluna = 4;

int[,] matriz = new int[linha, coluna];
PreencherMatriz(matriz);
int [,] matrizInvertida = GerarNovaMatrizInvertida(matriz);
Console.WriteLine("Matriz normal: ");
ExibirMatriz(matriz);
Console.WriteLine("Matriz invertida");
ExibirMatriz(matrizInvertida);

void PreencherMatriz(int[,] matriz)
{
    for(int i = 0; i < linha; i++)
    {
        for(int j = 0; j< coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1,10);
        }
    }
}

int[,] GerarNovaMatrizInvertida(int[,] matriz)
{
    int[,] novaMatriz = new int[linha, coluna];
    int auxLinha = 0;
    int auxColuna = 0;

    for(int i = linha-1; i>= 0; i--)
    {
        for( int j = coluna-1; j>= 0; j--)
        {
            novaMatriz[auxLinha, auxColuna] = matriz[i, j];
            auxColuna++;
        }
        auxColuna = 0;
        auxLinha++;
    }
    return novaMatriz;
}

void ExibirMatriz(int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{i}][{j}] = {matriz[i, j]} ");
        }
        Console.WriteLine();
    }
}