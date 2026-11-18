//A conta salario não possui limite.
public class ContaSalario : Conta
{
    public ContaSalario(int numeroDaConta) : base(numeroDaConta)
    {

    }

    public ContaSalario(int numeroDaConta, double Saldo) : base(numeroDaConta, Saldo)
    {

    }
}