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
    float valorVenda;

    Console.WriteLine($"Informe o Fabricante do carro {i + 1}: ");
    fabricante = Console.ReadLine();

    Console.WriteLine($"Informe o Modelo do carro {i + 1}: ");
    modelo = Console.ReadLine();

    Console.WriteLine($"Informe o Ano do Fabricante do carro {i + 1}: ");
    anoFabricante = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o Ano do Modelo do carro {i + 1}: ");
    anoModelo = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o Valor de venda do carro {i + 1}: ");
    valorVenda = float.Parse(Console.ReadLine());

    Console.WriteLine($"Informe tipo de Combustivel do veiculo {i+1}: ");
    string tipoCombustivel = Console.ReadLine();

    Console.WriteLine($"Informe cilindrada do motor {i+1}: ");
    int cilindrada = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe potencia do motor {i+1}: ");
    double potencia = double.Parse(Console.ReadLine());

    Carro c = new Carro(fabricante, modelo, anoFabricante, anoModelo, valorVenda, tipoCombustivel, cilindrada, potencia);

    return c;
}
void ImprimirCarros(Carro[] c)
{
    for (int i = 0; i < c.Length; i++)
    {
        Console.WriteLine(c[i]);
        Console.WriteLine("IPVA: R$" + c[i].IPVA().ToString("F2"));
    }
}