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

    public override string ToString()
    {
        return "Fabricante: " + Fabricante + "\nModelo: " + Modelo + "\nAno Fabricação: " + AnoFabricacao +
            "\nAno Modelo: " + AnoModelo + "\nValor de venda: " + ValorVenda;
    }
}


