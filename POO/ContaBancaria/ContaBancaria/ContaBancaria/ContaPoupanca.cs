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

    public override bool Sacar(double valor)
    {
        return base.Sacar(valor*taxa);
    }
    public override bool Pagar(double valorBoleto)
    {
        return base.Sacar(valorBoleto);
    }
}