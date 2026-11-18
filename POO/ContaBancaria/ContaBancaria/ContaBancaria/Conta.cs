//1 - crie uma classe de conta bancaria abstrata com as seguintes propriedades:
//Numero da conta 
//Saldo da conta
//os metodos da conta bancaria são os seguites:
//Depositar()
//Sacar()
//Transferir()
//Pagar()

public abstract class Conta
{
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }

    public Conta(int numeroConta)
    {
        NumeroConta = numeroConta;
        Saldo = 0;
    }

    public Conta(int numeroConta, double saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public virtual bool Depositar(double valor)
    {
        if (valor < 0)
            return false;
        Saldo += valor;
        return true;
    }

    public virtual bool Sacar(double valor)
    {
        if (valor < 0 || valor > Saldo)
            return false;
        Saldo -= valor;
        return true;
    }

    public virtual bool Transferir(Conta c, double valor)
    {
        if (!Sacar(valor))
            return false;
        c.Saldo += valor;
        return true;
    }

    public virtual bool Pagar(double valorBoleto)
    {
        if (valorBoleto < 0 || valorBoleto > Saldo)
            return false;
        Saldo -= valorBoleto;
        return true;
    }

    public override string ToString()
    {
        return "Numero da conta: "+ NumeroConta+"\nSaldo atual: "+Saldo;
    }
}