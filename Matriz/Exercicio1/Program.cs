//1 - Faça um programa que crie uma matriz de numeros inteiros na quantidade de linhas e colunas que o usuario informar.
//Essa matriz deve ser populada automaticamente e ser exibida do primeiro elemento ao ultimo elemento e do ultimo para o primeiro

using System.Security.Cryptography;

Console.WriteLine("Informe o numero de linhas da matriz: ");
int linha = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero de colunas da matriz: ");
int coluna = int.Parse(Console.ReadLine());

int[,] matriz = new int[linha, coluna];
PopularMatriz(matriz);
Console.WriteLine("Matriz preenchida: ");
ExibirMatriz(false);
Console.WriteLine("Matriz invertida: ");
ExibirMatriz(true);

void PopularMatriz(int[,] matriz)
{
    for(int i=0;i<linha; i++)
    {
        for(int j=0;j<coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        }
    }
}

void ExibirMatriz(bool invertida)
{
    if (invertida)
    {
        for(int i = linha-1; i>=0; i--)
        {
            for (int j = coluna-1; j >= 0; j--)
            {
                Console.Write($"[{i}][{j}] = {matriz[i,j]} ");
            }
            Console.WriteLine();
        }
    }
    else
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
}