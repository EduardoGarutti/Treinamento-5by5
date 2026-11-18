public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa Proximo;

    public Pessoa(string nome)
    {
        Nome = nome;
        Proximo = null;
    }
}