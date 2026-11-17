//A conta poupança, Todo o saque desconta 5% de taxa.
public class ContaSalario : Conta
{
    public ContaSalario(int numeroDaConta) : base(numeroDaConta)
    {

    }

    public ContaSalario(int numeroDaConta, double Saldo) : base(numeroDaConta, Saldo)
    {

    }
}