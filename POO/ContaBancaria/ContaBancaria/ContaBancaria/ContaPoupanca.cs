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
        if (valor < 0 || valor > Saldo)
            return false;
        valor = valor + (valor * taxa);
        Saldo -= valor;
        return false;
    }
    public override bool Pagar(double valorBoleto)
    {
        return base.Sacar(valorBoleto);
    }
}