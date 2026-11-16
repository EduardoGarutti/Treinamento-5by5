//1 - Faça um programa que crie 4 objetos do tipo "Carro", contendo:
// "Fabricante", "Modelo, "Ano de fabriação","Ano de modelo" e "valor de venda"
//Grave esses carros em um Vetor e faça a exibição do mesmo
Carro[] carro = new Carro[4];
PreencherVetor(carro);
ImprimirCarros(carro);
void PreencherVetor(Carro[] c)
{
    for (int i = 0; i < c.Length; i++)
    {
        c[i] = CriarCarro(i);
    }
}
Carro CriarCarro(int i)
{
    string fabricante, modelo;
    int anoModelo, anoFabricante;
    float valorVenda;

    Console.WriteLine($"Informe o Fabricante do carro {i+1}: ");
    fabricante = Console.ReadLine();

    Console.WriteLine($"Informe o Modelo do carro {i+1}: ");
    modelo = Console.ReadLine();

    Console.WriteLine($"Informe o Ano do Fabricante do carro {i+1}: ");
    anoFabricante = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o Ano do Modelo do carro {i+1}: ");
    anoModelo = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o Valor de venda do carro {i+1}: ");
    valorVenda = float.Parse(Console.ReadLine());

    Carro c = new Carro(fabricante, modelo, anoFabricante, anoModelo, valorVenda);

    return c;
}
void ImprimirCarros(Carro[] c)
{
    for(int i = 0;i < c.Length; i++)
    {
        Console.WriteLine(c[i]);
        Console.WriteLine();
    }
}