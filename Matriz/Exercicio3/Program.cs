//3 - Desenvolva um programa que crie preencha uma matriz de tamanho que será informada pelo usuario.
//Mostre os calculos somando os valores de cada linha, de cada coluna, da diagonal principal e inversa.

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Informe a quantidade de linhas da sua matriz: ");
int linhas = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de colunas da sua matriz: ");
int colunas = int.Parse(Console.ReadLine());

int[,] input = PreencherMatriz(linhas, colunas);
ImprimirMatriz(input, linhas, colunas);
SomarLinhas(input, linhas, colunas);
Console.WriteLine();
SomarColunas(input, linhas, colunas);
Console.WriteLine();
SomarDiagonais(input, linhas, colunas);

int[,] PreencherMatriz(int linhas, int colunas)
{
    int[,] novaMatriz = new int[linhas, colunas];
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            novaMatriz[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return novaMatriz;
}

void SomarLinhas(int[,] matriz, int linhas, int colunas)
{
    int aux;
    for(int i = 0;i<linhas; i++)
    {
        aux = 0;
        for(int j=0; j<colunas; j++)
        {
            aux += matriz[i, j];
        }
        Console.WriteLine($"Soma da linha {i}: "+ aux);
    }
}

void SomarColunas(int[,] matriz, int linhas, int colunas)
{
    int aux;
    for (int i = 0; i < colunas; i++)
    {
        aux = 0;
        for (int j = 0; j < linhas; j++)
        {
            aux += matriz[j, i];
        }
        Console.WriteLine($"Soma da coluna {i}: " + aux);
    }
}

void SomarDiagonais(int[,] matriz, int linhas, int colunas)
{
    int diagonal=0, diagonalInvertida = 0;

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            if (i == j)
            {
                diagonal += matriz[i, j];
            } 
            if(j==(colunas - 1 - i)){
                diagonalInvertida += matriz[i, j];
            }
        }
    }
    Console.WriteLine($"Diagonal normal: {diagonal}\n" +
        $"Diagonal invertida: {diagonalInvertida}");
}

void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
{
    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            Console.Write($"[{matriz[i,j]}]");
        }
        Console.WriteLine();
    }
}

