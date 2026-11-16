public class Carro
{
    public string Fabricante, Modelo;
    public int AnoFabricacao, AnoModelo;
    public float ValorVenda;

    public Carro(string Fabricante, string Modelo, int AnoFabricacao, int AnoModelo, float ValorVenda)
    {
        this.Fabricante = Fabricante;
        this.Modelo = Modelo;
        this.AnoFabricacao = AnoFabricacao;
        this.AnoModelo  = AnoModelo;
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
        this.AnoFabricacao= AnoFabricacao;
    }

    public int getAnoFabricacao()
    {
        return this.AnoFabricacao;
    }

    public void setAnoModelo(int AnoModelo)
    {
        this.AnoFabricacao = AnoModelo;
    }

    public int getAnoModelo()
    {
        return this.AnoModelo;
    }

    public void setValorVenda(float ValorVenda)
    {
        this.ValorVenda= ValorVenda;
    }
    
    public float getValorVenda()
    {
        return this.ValorVenda;
    }

    public override string ToString()
    {
        return "Fabricante: " + Fabricante + "\nModelo: " + Modelo + "\nAno Fabricação: " + AnoFabricacao +
            "\nAno Modelo: " + AnoModelo + "\nValor de venda: " + ValorVenda;
    }
}


