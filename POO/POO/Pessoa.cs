public class Pessoa
{
    public string Nome;
    public int Idade;
    public char Sexo;

    public Pessoa(string Nome,  int Idade, char Sexo)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Sexo = Sexo;
    }

    //public void SetNome()
    //{
    //    Console.WriteLine("Informe seu nome: ");
    //    this.Nome = Console.ReadLine();
    //}

    public void SetNome(string Nome)
    {
        this.Nome = Nome;
    }

    public string GetNome()
    {
        return this.Nome;
    }

    public override string ToString()
    {
        return "Nome: "+ Nome+"\nIdade: "+Idade+"\nSexo: " + Sexo;
    }
}
