//2 - Faça um programa que gere uma matriz 3x5 populada automaticamente e baseada nela gere uma nova matriz inversa.

using System.Security.Cryptography;

const int linha = 3;
const int coluna = 4;

int[,] matriz = new int[linha, coluna];
PreencherMatriz(matriz);
int [,] matrizInvertida = GerarNovaMatrizInvertida(matriz);
int[,] matrizEspelhada = GerarNovaMatrizEspelhada(matriz);
Console.WriteLine("\n------------------------------------------\nMatriz normal: ");
ExibirMatriz(matriz);
Console.WriteLine("\n------------------------------------------\nMatriz invertida:");
ExibirMatriz(matrizInvertida);
Console.WriteLine("\n------------------------------------------\nMatriz Espelhada:");
ExibirMatriz(matrizEspelhada);


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
    int[,] novaMatriz = new int[coluna, linha];
    for (int i = 0; i < coluna; i++)
    {
        for (int j = 0; j < linha; j++)
        {
            novaMatriz[i, j] = matriz[j, i];

        }
    }
    return novaMatriz;
}
int[,] GerarNovaMatrizEspelhada(int[,] matriz)
{
    int[,] novaMatriz = new int[linha, coluna];
    int auxLinha = linha-1;
    int auxColuna = coluna-1;

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            novaMatriz[i, j] = matriz[auxLinha, auxColuna];
            auxColuna--;
        }
        auxColuna = coluna-1;
        auxLinha--;

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