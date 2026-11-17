public class PessoaFisica : Pessoa
{
    public string CPF {  get; set; }
    public string Mobile { get; set; }
    public char Gender {  get; set; }

    public PessoaFisica(string cpf, string name):base(name)
    {
        CPF = cpf;
    }

    public PessoaFisica(string cpf, string name, string phone) : base(name, phone)
    {
        CPF = cpf;
    }

    public override string ToString()
    {
        return base.ToString()+"\nCPF: "+CPF+"\nCelular: "+Mobile+"\nGenero: "+Gender;
    }
}
