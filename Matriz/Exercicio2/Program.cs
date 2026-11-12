//2 - Faça um programa que gere uma matriz 3x5 populada automaticamente e baseada nela gere uma nova matriz inversa.

using System.Security.Cryptography;

const int linha = 3;
const int coluna = 4;

int[,] matriz = new int[linha, coluna];
PreencherMatriz(matriz);
int[,] matriztransposta = GerarNovaMatrizTransposta(matriz);
int[,] matrizEspelhada = GerarNovaMatrizEspelhada(matriz);
Console.WriteLine("\n------------------------------------------\n" +
    "Matriz normal: ");
ExibirMatriz(matriz, linha, coluna);
Console.WriteLine("\n------------------------------------------\n" +
    "Matriz Transposta:");
ExibirMatriz(matriztransposta, coluna, linha);
Console.WriteLine("\n------------------------------------------\n" +
    "Matriz Espelhada:");
ExibirMatriz(matrizEspelhada, linha, coluna);


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

int[,] GerarNovaMatrizTransposta(int[,] matriz)
{
    int[,] novaMatriz = new int[coluna, linha];
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            novaMatriz[j, i] = matriz[i, j];

        }
    }
    return novaMatriz;
}
int[,] GerarNovaMatrizEspelhada(int[,] matriz)
{
    int[,] novaMatriz = new int[linha, coluna];
    int auxLinha = linha - 1;
    int auxColuna = coluna - 1;

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            novaMatriz[i, j] = matriz[auxLinha, auxColuna];
            auxColuna--;
        }
        auxColuna = coluna - 1;
        auxLinha--;

    }
    return novaMatriz;
}
void ExibirMatriz(int[,] matriz, int linha, int coluna)
{

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
        Console.WriteLine();
    }


}