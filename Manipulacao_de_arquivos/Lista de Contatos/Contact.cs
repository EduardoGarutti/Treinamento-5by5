public class Contact(string n)
{
    //public int Id { get; set; }
    public string Name { get; set; } = n;
    public string Phone{ get; set; }
    public char Gender{ get; set; }

    public Contact(string name, string phone, char gender) : this(name)
    {
        Phone = phone;
        Gender = gender;
    }

    public string GravarNoArquivo()
    {
        return $"{Name},{Phone},{Gender}";
    }

    public override string ToString()
    {
        return $"Nome: {Name} - Telefone: {Phone} - Genero: {Gender}";
    }
}