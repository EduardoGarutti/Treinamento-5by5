public class Motor
{
    public string Combustivel;
    public int Cilindrada;
    public int Potencia;

    public Motor(string Combustivel, int Cilindrada, int Potencia)
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

    public void setPotencia(int Potencia)
    {
        this.Potencia= Potencia;
    }

    public int getPotenca()
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