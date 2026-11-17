public class Carro
{
    Motor motor;
    public string Fabricante, Modelo;
    public int AnoFabricacao, AnoModelo;
    public float ValorVenda;

    const double ALIQUOTA = 0.04;

    public Carro(string Fabricante, string Modelo, int AnoFabricacao, int AnoModelo, float ValorVenda,
        string Combustivel, int Cilindrada, double Potencia)
    {
        motor = new Motor(Combustivel, Cilindrada, Potencia);
        this.Fabricante = Fabricante;
        this.Modelo = Modelo;
        this.AnoFabricacao = AnoFabricacao;
        this.AnoModelo = AnoModelo;
        this.ValorVenda = ValorVenda;
    }

    public void setFabricante(string Fabricante)
    {
        this.Fabricante = Fabricante;
    }

    public string getFabricante()
    {
        return this.Fabricante;
    }

    public void setModelo(string Modelo)
    {
        this.Modelo = Modelo;
    }

    public string getModelo()
    {
        return this.Modelo;
    }

    public void setAnoFabricacao(int AnoFabricacao)
    {
        this.AnoFabricacao = AnoFabricacao;
    }

    public int getAnoFabricacao()
    {
        return this.AnoFabricacao;
    }

    public void setAnoModelo(int AnoModelo)
    {
        if (ValidarAnoModelo(AnoModelo))
            this.AnoFabricacao = AnoModelo;
        else
            this.AnoModelo = AnoFabricacao;
    }

    private bool ValidarAnoModelo(int ano)
    {
        if (ano == AnoFabricacao || ano == AnoFabricacao + 1)
            return true;
        else
            return false;
    }

    public int getAnoModelo()
    {
        return this.AnoModelo;
    }

    public void setValorVenda(float ValorVenda)
    {
        this.ValorVenda = ValorVenda;
    }

    public float getValorVenda()
    {
        return this.ValorVenda;
    }

    public double IPVA()
    {
        if (2026 - AnoFabricacao > 20)
            return 0;

        return ValorVenda * ALIQUOTA;
    }

    public override string ToString()
    {
        return "Fabricante: " + Fabricante + "\nModelo: " + Modelo + "\nAno Fabricação: " + AnoFabricacao +
            "\nAno Modelo: " + AnoModelo + "\nValor de venda: " + ValorVenda + "\n"+motor;
    }
}


