public class Senha
{
    public string Codigo { get; set; }
    public Senha? Proximo;

    public Senha(string codigo)
    {
        Codigo = codigo;
        Proximo = null;
    }
}