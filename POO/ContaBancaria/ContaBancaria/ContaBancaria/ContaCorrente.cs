//A conta corrente (cc) possui a propriedade "Limite" que é sempre definida automaticamente pelo triplo do saldo. 
//Caso o saldo esteja negativo, o limite é zerado
public class ContaCorrente : Conta
{
    public double Limite { get; set; }

    public ContaCorrente (int numeroConta, double saldo) : base(numeroConta, saldo)
    {
        Limite = saldo*3;
    }

    public ContaCorrente(int numeroConta) : base(numeroConta)
    {
        Limite = 0;
    }

    public void setLimite(double saldo)
    {
        if (saldo < 0)
            Limite = 0;
        else
            Limite = saldo * 3;
    }

    public override void Depositar(double valor)
    {
        this.Saldo += valor;
        setLimite(this.Saldo);
    }

    public override void Sacar(double valor)
    {
        this.Saldo -= valor;
        setLimite(this.Saldo);
    }

    public override string ToString()
    {
        return base.ToString() + "Limite: "+ Limite;
    }
}