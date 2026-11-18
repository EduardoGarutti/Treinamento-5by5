//A conta corrente (cc) possui a propriedade "Limite" que é sempre definida automaticamente pelo triplo do saldo. 
//Caso o saldo esteja negativo, o limite é zerado
public class ContaCorrente : Conta
{
    public double Limite;

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

    public override bool Depositar(double valor)
    {
        if (!base.Depositar(valor))
            return false;
        setLimite(this.Saldo);
        return true;
    }

    public override bool Sacar(double valor)
    {
        if (valor < 0)
            return false;
        if(valor <= Limite+Saldo)
        {
            this.Saldo -= valor;
            setLimite(this.Saldo);
            return true;
        }
        return false;  
    }

    public override bool Transferir(Conta c, double valor)
    {
        if (Saldo < 1)
            return false;
        return base.Transferir(c, valor);
    }

    public override string ToString()
    {
        return base.ToString() + "\nLimite: "+ Limite;
    }
}