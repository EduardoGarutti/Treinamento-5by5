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

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public virtual void Transferir(Conta c, double valor)
    {
        Sacar(valor);
        c.Saldo += valor;
    }

    public virtual void Pagar(double valorBoleto)
    {
        Saldo -= valorBoleto;
    }

    public override string ToString()
    {
        return "Numero da conta: "+ NumeroConta+"\nSaldo atual: "+Saldo;
    }
}