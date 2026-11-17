//Dando continuidade ao exercício1 de implementação da classe Carro,
//amplie suas funcionalidades adicionando o cálculo do IPVA e uma nova classe
//chamada Motor que deverá possuir os seguintes atributos:
//-Combustivel: do tipo string, responsável por identificar o tipo de
//  combustível utilizado pelo motor.
//- Cilindrada: responsável por armazenar a cilindrada do motor.
//- Potencia: 
 
 

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
    double valorVenda;

    Console.WriteLine($"Informe o Fabricante do carro {i + 1}: ");
    fabricante = Console.ReadLine();

    Console.WriteLine($"Informe o Modelo do carro {i + 1}: ");
    modelo = Console.ReadLine();

    Console.WriteLine($"Informe o Ano do Fabricante do carro {i + 1}: ");
    anoFabricante = int.Parse(Console.ReadLine());
    anoFabricante = ValidarInt(anoFabricante);

    Console.WriteLine($"Informe o Ano do Modelo do carro {i + 1}: ");
    anoModelo = int.Parse(Console.ReadLine());
    anoModelo = ValidarInt(anoModelo);

    Console.WriteLine($"Informe o Valor de venda do carro {i + 1}: ");
    valorVenda = double.Parse(Console.ReadLine());
    valorVenda = ValidarDouble(valorVenda);

    Console.WriteLine($"Informe tipo de Combustivel do veiculo {i+1}: ");
    string tipoCombustivel = Console.ReadLine();

    Console.WriteLine($"Informe cilindrada do motor {i+1}: ");
    int cilindrada = int.Parse(Console.ReadLine());
    cilindrada = ValidarInt(cilindrada);

    Console.WriteLine($"Informe potencia do motor {i+1}: ");
    int potencia = int.Parse(Console.ReadLine());
    potencia = ValidarInt(potencia);

    Carro c = new Carro(fabricante, modelo, anoFabricante, anoModelo, valorVenda, 
        tipoCombustivel, cilindrada, potencia);

    return c;
}

int ValidarInt(int a)
{
    while (a <= 0)
    {
        Console.WriteLine("O valor informado não pode ser menor ou igual a 0!");
        a = int.Parse(Console.ReadLine());
    }
    return a;
}

double ValidarDouble(double a)
{
    while (a <= 0)
    {
        Console.WriteLine("O valor informado não pode ser menor ou igual a 0!");
        a = double.Parse(Console.ReadLine());
    }
    return a;
}
void ImprimirCarros(Carro[] c)
{
    for (int i = 0; i < c.Length; i++)
    {
        Console.WriteLine(c[i]);
        Console.WriteLine();
    }
}