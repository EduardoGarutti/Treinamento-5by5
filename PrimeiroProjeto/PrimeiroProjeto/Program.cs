using System.ComponentModel.Design;

const int LINHAS = 8, COLUNAS = 8;
int[,] matrizUsuario = new int[LINHAS, COLUNAS];
int[,] matrizInimiga = new int[LINHAS, COLUNAS];
string[,] matrizFakeInimiga = new string[LINHAS, COLUNAS];
string[,] matrizFakeUsuario = new string[LINHAS, COLUNAS];
int contNavios = 0;

InicializarCampoReal(matrizUsuario);
InicializarCampoReal(matrizInimiga);
GerarNavios(matrizUsuario);
GerarNavios(matrizInimiga);
InicializarCampoFakeInimigo(matrizFakeInimiga);
InicializarCampoFakeUsuario(matrizFakeUsuario, matrizUsuario);
bool fim = true;
bool ganhador = false;
Jogar();
void Jogar()
{
    while (fim)
    {
        ImprimirJogo(matrizFakeUsuario, matrizFakeInimiga);
        int linha = 0; int coluna = 0;
        linha = InformarAtaqueLinha(linha);
        coluna = InformarAtaqueColuna(coluna);
        while (PosicaoJaFoiAtacada(matrizInimiga, linha, coluna))
        {
            Console.WriteLine("Posição ja atacada! informar nova posição: ");
            linha = InformarAtaqueLinha(linha);
            coluna = InformarAtaqueColuna(coluna);
        }
        if (Acertou(matrizInimiga, linha, coluna))
        {
            Console.WriteLine("Voce acertou o navio inimigo!");
            MostraHit(matrizInimiga, matrizFakeInimiga, linha, coluna, true);
            fim = ExisteNavios(matrizInimiga);
            ganhador = true;
        }
        else
        {
            Console.WriteLine("Voce não acertou! ");
            MostraHit(matrizInimiga, matrizFakeInimiga, linha, coluna, true);
        }
        contNavios = 0;
        fim = ExisteNavios(matrizInimiga);
        Console.WriteLine("Restam " + contNavios + " navio(s) no campo inimigo!\n");
        AtaqueInimigo(matrizUsuario, matrizFakeUsuario);
        contNavios = 0;
        fim = ExisteNavios(matrizUsuario);
        Console.WriteLine("Restam " + contNavios + " navio(s) no campo Aliado!\n");
        ganhador = false;
    }

    if (ganhador)
    {
        Console.WriteLine("Usuario ganhou!");
    }
    else
    {
        Console.WriteLine("Maquina ganhou! ");
    }
}
void AtaqueInimigo(int[,] matriz, string[,] matrizFake)
{
    int linha = Random.Shared.Next(0, 8);
    int coluna = Random.Shared.Next(0, 8);
    while (PosicaoJaFoiAtacada(matriz, linha, coluna))
    {
        linha = Random.Shared.Next(0, 8);
        coluna = Random.Shared.Next(0, 8);
    }

    if (Acertou(matriz, linha, coluna))
    {
        Console.WriteLine("O inimigo te acertou!");
        MostraHit(matriz, matrizFake, linha, coluna, false);
    }
    else
    {
        Console.WriteLine("O inimigo não te acertou!");
        MostraHit(matriz, matrizFake, linha, coluna, false);
    }
}
int InformarAtaqueLinha(int linha)
{
    Console.WriteLine("Informe linha que deseja atacar(0-7): ");
    linha = int.Parse(Console.ReadLine()!);

    while (linha > 7 || linha < 0)
    {
        Console.WriteLine("Valor da linha está invalido! Informe novamente (0-7): ");
        linha = int.Parse(Console.ReadLine()!);
    }
    return linha;
}
int InformarAtaqueColuna(int coluna)
{
    Console.WriteLine("Informe coluna que deseja atacar(0-7): ");
    coluna = int.Parse(Console.ReadLine()!);

    while (coluna > 7 || coluna < 0)
    {
        Console.WriteLine("Valor da coluna está invalido! Informe novamente (0-7): ");
        coluna = int.Parse(Console.ReadLine()!);
    }
    return coluna;
}
bool PosicaoJaFoiAtacada(int[,] matriz, int linha, int coluna)
{
    if (matriz[linha, coluna] == 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void GerarNavios(int[,] matriz)
{
    for (int i = 1; i <= 4; i++)
    {
        int linha = Random.Shared.Next(0, 8);
        int coluna = Random.Shared.Next(0, 8);
        int decisao = Random.Shared.Next(0, 2);

        switch (decisao)
        {
            case 0:
                while (PercorreLinha(matriz, linha, i))
                {
                    linha = Random.Shared.Next(0, 7);
                }
                break;
            case 1:
                while (PercorreColuna(matriz, coluna, i))
                {
                    coluna = Random.Shared.Next(0, 7);
                }
                break;
        }
    }
}
bool PercorreLinha(int[,] matriz, int linha, int aux)
{
    int posicao = Random.Shared.Next(0, 8 - aux + 1);
    for (int i = posicao; i < posicao + aux; i++)
    {
        if (matriz[linha, i] != 0)
        {
            return true;
        }
    }

    for (int i = posicao; i < posicao + aux; i++)
    {
        matriz[linha, i] = 1;
    }
    return false;
}
bool PercorreColuna(int[,] matriz, int coluna, int aux)
{
    int posicao = Random.Shared.Next(0, 8 - aux + 1);
    for (int i = posicao; i < posicao + aux; i++)
    {
        if (matriz[i, coluna] != 0)
        {
            return true;
        }
    }
    for (int i = posicao; i < posicao + aux; i++)
    {
        matriz[i, coluna] = 1;
    }
    return false;
}
void InicializarCampoReal(int[,] matriz)
{
    for (int i = 0; i < LINHAS; i++)
    {
        for (int j = 0; j < COLUNAS; j++)
        {
            matriz[i, j] = 0;
        }
    }
}
void InicializarCampoFakeInimigo(string[,] matriz)
{
    for (int i = 0; i < LINHAS; i++)
    {
        for (int j = 0; j < COLUNAS; j++)
        {
            matriz[i, j] = "~";
        }
    }
}
void InicializarCampoFakeUsuario(string[,] matrizString, int[,] matrizInt)
{
    for (int i = 0; i < LINHAS; i++)
    {
        for (int j = 0; j < COLUNAS; j++)
        {
            matrizString[i, j] = matrizInt[i, j].ToString();
        }
    }
}
void ImprimirJogo(string[,] matrizJogador, string[,] matrizInimiga)
{
    Console.WriteLine("                 BATALHA NAVAL");
    Console.WriteLine("==============================================");
    Console.Write("  ");
    for (int i = 0; i < LINHAS; i++)
    {
        Console.Write(i+" ");
    }
    Console.Write("\t\t");
    Console.Write("  ");
    for (int i = 0; i < LINHAS; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < LINHAS; i++)
    {
        Console.Write(i+" ");
        for (int j = 0; j < COLUNAS; j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(matrizJogador[i, j] + " ");
        }
        Console.Write("\t\t");
        Console.ResetColor();
        Console.Write(i + " ");
        for (int j = 0; j < COLUNAS; j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrizInimiga[i, j] + " ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
    Console.WriteLine();
}
bool Acertou(int[,] matriz, int linha, int coluna)
{
    if (matriz[linha, coluna] != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void MostraHit(int[,] matrizReal, string[,] matrizFake, int linha, int coluna, bool isUsuario)
{

    if (Acertou(matrizReal, linha, coluna))
    {
        matrizFake[linha, coluna] = "N";
        matrizReal[linha, coluna] = 2;
    }
    else
    {
        matrizFake[linha, coluna] = "X";
        matrizReal[linha, coluna] = 2;
    }
}
bool ExisteNavios(int[,] matriz)
{
    for (int i = 0; i < LINHAS; i++)
    {
        for (int j = 0; j < COLUNAS; j++)
        {
            if (matriz[i, j] == 1)
            {
                contNavios++;
            }
        }
    }
    if (contNavios != 0)
    {
        return true;
    }
    return false;
}
