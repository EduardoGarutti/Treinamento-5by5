//2 - Faça um programa que crie uma classe "Conta Bancaria", com os atributos:
//string titular
//double saldo
//Adicione os seguinte metodos a essa classe:
//"Depositar" recebendo um parametro double 
//"Sacar" recebendo um parametro double
//Exibir saldo Mostrando o saldo formatado
//ToString com as informações da conta

Conta_Bancaria conta;

Conta_Bancaria CadastrarConta()
{
    Console.WriteLine("Informe o nome do titular da conta: ");
    string titular = Console.ReadLine();

    Console.WriteLine("Informe o saldo da conta: ");
    double saldo = double.Parse(Console.ReadLine());

    Conta_Bancaria c = new(titular, saldo);

    return c;
}

void RealizarDeposito(Conta_Bancaria conta)
{
    Console.WriteLine("Informe um valor para depositar na conta: ");
    double valor = double.Parse(Console.ReadLine());

    while (!conta.Depositar(valor))
    {
        Console.WriteLine("O valor depositado não pode ser negativo!");
    }

    Console.WriteLine("Valor depositado com sucesso!");
}

void Sacar(Conta_Bancaria conta)
{
    Console.WriteLine($"Informe um valor para Sacar (Saldo atual: {conta.getSalario})");
    double valor = double.Parse(Console.ReadLine());

    while (!conta.Depositar(valor))
    {
        Console.WriteLine("O valor sacado não pode ser maior que o Saldo atual ou negativo!");
    }

    Console.WriteLine($"Valor Sacado com sucesso! (Saldo atual: {conta.getSalario})");
}

void ImprimirInformacoes(Conta_Bancaria conta)
{
    Console.WriteLine(conta);
}

