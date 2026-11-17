public abstract class Pessoa
{
    public string Name { get; set; }
    public string Address { get; set; }
    public DateOnly Date { get; set; }
    public string Phone {  get; set; }

    public Pessoa(string name)
    {
        Name = name;
        Date = DateOnly.FromDateTime(DateTime.Now);
    }

    public Pessoa(string name, string phone)
    {
        Name = name;
        Phone = phone;
        Date = DateOnly.FromDateTime(DateTime.Now);
    }

    public override string ToString()
    {
        return "Nome: "+Name+"\nData de criação: "+Date+"\nTelefone: "+Phone;
    }
}
