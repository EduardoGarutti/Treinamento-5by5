//1 - crie uma classe de conta bancaria abstrata com as seguintes propriedades:
//Numero da conta 
//Saldo da conta
//os metodos da conta bancaria são os seguites:
//Depositar()
//Sacar()
//Transferir()
//Pagar()

//Existem 3 tipos de conta: 
//Conta Corrente 
//Conta poupança  
//Conta salario. 

//A conta corrente (cc) possui a propriedade "Limite" que é sempre definida automaticamente pelo triplo do saldo. 
//Caso o saldo esteja negativo, o limite é zerado
//A conta poupança, Todo o saque desconta 5% de taxa.
//A conta salario não possui limite.

//Faça um programa que gerencie 3 contas definidas pelo usuario.

const int qntDeContas = 3;
Conta[] conta = new Conta[qntDeContas];
PopularContas();
Menu();

Conta CriarConta(int escolha)
{
    Console.WriteLine("Informe numero da conta: ");
    int nmrDaConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe saldo Inicial: ");
    double saldo = double.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            return new ContaCorrente(nmrDaConta, saldo);
        case 2:
            return new ContaPoupanca(nmrDaConta, saldo);
        case 3:
            return new ContaSalario(nmrDaConta, saldo);
        default:
            return null;
    }
}
void PopularContas()
{
    for (int i = 0; i < qntDeContas; i++)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("[1] - Conta Corrente");
        Console.WriteLine("[2] - Conta Poupança");
        Console.WriteLine("[3] - Conta Salario");
        Console.WriteLine("======================================");
        int escolha = int.Parse(Console.ReadLine());
        while (escolha > 3 || escolha <= 0)
        {
            Console.WriteLine("O numero escolhido nao pode ser negativo ou maior que 3!");
            escolha = int.Parse(Console.ReadLine());
        }
        conta[i] = CriarConta(escolha);
    }
    Console.WriteLine("Contas criadas com sucesso!");
}
void Menu()
{
    bool sair = true;
    while (sair)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("[1] - Imprimir Todas as contas");
        Console.WriteLine("[2] - Selecionar uma conta");
        Console.WriteLine("[3] - Sair");
        Console.WriteLine("======================================");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                ImprimirContas();
                break;
            case 2:
                Console.WriteLine("Informe o indice da conta (0 a 2)");
                int contaEscolhida = int.Parse(Console.ReadLine());

                if (contaEscolhida > qntDeContas || contaEscolhida < 0)
                {
                    Console.WriteLine("Conta invalida!");
                    break;
                }
                ManipularConta(contaEscolhida);
                break;
            case 3:
                Console.WriteLine("Encerrando o programa..");
                sair = false;
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;
        }
    }
}
void ManipularConta(int aux)
{
    bool sair = true;
    while (sair)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("Conta: " + aux);
        Console.WriteLine("[1] - Depositar");
        Console.WriteLine("[2] - Sacar");
        Console.WriteLine("[3] - Transferir saldo para outra conta");
        Console.WriteLine("[4] - Pagar Boleto");
        Console.WriteLine("[5] - Sair");
        Console.WriteLine("======================================");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Informe valor do deposito: ");
                double valorDeposito = double.Parse(Console.ReadLine());

                while (!conta[aux].Depositar(valorDeposito))
                {
                    Console.WriteLine("O valor do deposito nao pode ser negativo!");
                    valorDeposito = double.Parse(Console.ReadLine());
                }
                break;
            case 2:
                Console.WriteLine("Informe valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                while (!conta[aux].Sacar(valorSaque))
                {
                    Console.WriteLine("Valor de saque invalido! ");
                    valorSaque = double.Parse(Console.ReadLine());
                }
                break;
            case 3:
                ImprimirContas();
                Console.WriteLine("Informe o Numero Da Conta da conta que deseja efetuar a transferencia: ");
                int numeroDaConta = int.Parse(Console.ReadLine());

                Conta destinatario = ProcurarConta(numeroDaConta);
                if(destinatario == null)
                {
                    Console.WriteLine("Numero da conta Invalido!");
                    break;
                }

                Console.WriteLine("Informe o valor a ser depositado: ");
                double valorTransferencia = double.Parse(Console.ReadLine());

                if (!ValidarTransferencia(conta[aux], valorTransferencia))
                {
                    Console.WriteLine("Saldo insuficiente! transação nao realizada");
                    break;
                }
                conta[aux].Transferir(destinatario, valorTransferencia);
                Console.WriteLine("Transação realizada com sucesso!");
                break;
            case 4:
                Console.WriteLine("Informe valor do boleto! ");
                double boleto = double.Parse(Console.ReadLine());

                if (!conta[aux].Pagar(boleto))
                {
                    Console.WriteLine("Valor do boleto negativo ou acima do seu saldo!");
                    break;
                }
                Console.WriteLine("Boleto pago com sucesso!");
                break;
            case 5:
                sair = false;
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;
        }
    }
}
Conta ProcurarConta(int aux)
{
    for(int i = 0; i < qntDeContas; i++)
    {
        if (conta[i].NumeroConta == aux)
        {
            return conta[i];
        }
    }
    return null;
}
bool ValidarTransferencia(Conta remetente, double valor)
{
    if (valor <= 0 || remetente.Saldo < valor)
        return false;

    return true;

}
void ImprimirContas()
{
    for (int i = 0; i < qntDeContas; i++)
    {
        Console.WriteLine($"Conta[{i}]: {conta[i].GetType()}\n{conta[i]}\n");
    }
}
