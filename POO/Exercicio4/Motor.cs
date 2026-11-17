public class Motor
{
    public string Combustivel;
    public int Cilindrada;
    public double Potencia;

    public Motor(string Combustivel, int Cilindrada, double Potencia)
    {
        this.Combustivel = Combustivel;
        this.Cilindrada = Cilindrada;
        this.Potencia = Potencia;
    }

    public void setCombustivel(string Combustivel)
    {
        this.Combustivel= Combustivel;
    }

    public string getCombustivel()
    {
        return this.Combustivel;
    }

    public void setCilindrada(int Cilindrada)
    {
        this.Cilindrada= Cilindrada;
    }

    public int getCilindrada()
    {
        return Cilindrada;
    }

    public void setPotencia(double Potencia)
    {
        this.Potencia= Potencia;
    }

    public double getPotenca()
    {
        return Potencia;
    }

    public override string ToString()
    {
        return "Combustivel: " + Combustivel +
            "\nCilindrada: " + Cilindrada +
            "\nPotencia: " + Potencia;
    }
}