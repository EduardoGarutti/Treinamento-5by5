List<Contact> listaDeContatos = new List<Contact>();
const string PATH = @"C:\dev\teste\";
const string FILE = "atividade.csv";
const string PATHFILE = PATH + FILE;

Menu();

bool ValidarCaminho(string p)
{
    if (Directory.Exists(p))
        return true;
    try
    {
        Directory.CreateDirectory(p);
        return true;
    }
    catch (DirectoryNotFoundException e)
    {
        Console.WriteLine(e.Message);
        return false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return false;
    }
}
bool ValidarArquivo(string p)
{
    if (File.Exists(p))
        return true;

    try
    {
        if (ValidarCaminho(p))
        {
            File.Create(PATHFILE).Close();
            return true;
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return false;
    }
    return false;
}
void MostrarContatos()
{
    foreach(var c in listaDeContatos)
    {
        Console.WriteLine(c);
    }
}
void AdicionarContatoNoArquivo(Contact obj)
{
    if (ValidarArquivo(PATHFILE))
    {
        listaDeContatos.Clear();
        var reader = new StreamReader(PATHFILE);
        string[] aux;

        while (reader.Peek() != -1)
        {
            aux = reader.ReadLine().Split(',');

            listaDeContatos.Add(new Contact(aux[0], aux[1], aux[2][0]));
        }
        reader.Close();

        listaDeContatos.Add(obj);


        var writer = new StreamWriter(PATHFILE);

        foreach (Contact c in listaDeContatos)
        {
            writer.WriteLine(c.GravarNoArquivo());
        }

        writer.Close();
    }
}
Contact InformarContato()
{
    try
    {
        Console.WriteLine("Informe o Nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o telefone: ");
        string telefone = Console.ReadLine();

        Console.WriteLine("informe o genero: ");
        char genero = char.Parse(Console.ReadLine());
        return new Contact(nome, telefone, genero);
    }
    catch(Exception e)
    {
        Console.WriteLine("Informação preenchida incorretamente!");
        return InformarContato();
    }
}
void Menu()
{
    while (true)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("[1] - Informar novo contato");
        Console.WriteLine("[2] - Imprimir todos os contatos");
        Console.WriteLine("[3] - Sair");
        Console.WriteLine("======================================");

        Decisao();
    }
}
void Decisao()
{
    int decisao;
    try
    {
        decisao = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("O valor informado não é um numero! ");
        return;
    }

    switch (decisao)
    {
        case 1:
            AdicionarContatoNoArquivo(InformarContato());
            break;
        case 2:
            MostrarContatos();
            break;
        case 3:
            Console.WriteLine("Encerrando o programa!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Numero invalido!");
            break;
    }

}