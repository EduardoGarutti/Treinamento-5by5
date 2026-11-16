//1 - Faça um programa que crie 4 objetos do tipo "Carro", contendo:
// "Fabricante", "Modelo, "Ano de fabriação","Ano de modelo" e "valor de venda"
//Grave esses carros em um Vetor e faça a exibição do mesmo
string fabricante, modelo;
int anoModelo, anoFabricante;
float valorVenda;

Carro[] carro = new Carro[4];

CriarCarros(carro);
ImprimirCarros(carro);
void CriarCarros(Carro[] c)
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"Informe o Fabricante do carro {i}: ");
        fabricante = Console.ReadLine();

        Console.WriteLine($"Informe o Modelo do carro {i}: ");
        modelo = Console.ReadLine();

        Console.WriteLine($"Informe o Ano do Fabricante do carro {i}: ");
        anoFabricante = int.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o Ano do Modelo do carro {i}: ");
        anoModelo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Informe o Valor de venda do carro {i}: ");
        valorVenda = float.Parse(Console.ReadLine());

        c[i] = new Carro(fabricante, modelo, anoFabricante, anoModelo, valorVenda);
    }
}

void ImprimirCarros(Carro[] c)
{
    for(int i = 0;i < 4; i++)
    {
        Console.WriteLine(c[i]);
        Console.WriteLine();
    }
}