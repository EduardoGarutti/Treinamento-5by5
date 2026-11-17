public class Conta_Bancaria
{
    public string Titular;
    public double Salario;


    public Conta_Bancaria(string Titular, double Salario)
    {
        this.Titular = Titular;
        this.Salario = Salario;
    }

    public void setTitular(string Titular)
    {
        this.Titular = Titular;
    }

    public string getTitular()
    {
        return this.Titular;
    }

    public void setSalario(double Salario)
    {
        this.Salario = Salario;
    }

    public double getSalario()
    {
        return this.Salario;
    }

    public bool Depositar(double saldo)
    {
        if(saldo < 0)
        {
            return false;
        }

        this.Salario += saldo;
        return true;
    }

    public bool Sacar(double saque)
    {
        if(saque > Salario || saque < 0)
        {
            return false;
        }
        Salario -= saque;
        return true;
    }

    public override string ToString()
    {
        return "Titular: " + Titular+"\nSalario: "+Salario;
    }
}