//A conta poupança, Todo o saque desconta 5% de taxa.
public class ContaPoupanca : Conta
{
    const float taxa = 0.052f;

    public ContaPoupanca(int numeroDaConta) : base(numeroDaConta)
    {

    }

    public ContaPoupanca(int numeroDaConta, double Saldo) : base(numeroDaConta, Saldo)
    {

    }

    public override void Sacar(double valor)
    {
        valor = valor + (valor * taxa);
        Saldo -= valor;
    }
}