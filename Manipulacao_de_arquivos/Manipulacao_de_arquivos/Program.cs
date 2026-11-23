var path = @"C:\dev\";
var file = "dados.dat";

bool PathValidation(string p)
{
    if (Directory.Exists(p))
        return true;
    try
    {
        Directory.CreateDirectory(p);
        return true;
    }
    catch(DirectoryNotFoundException e)
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

bool FileValidation(string p)
{
    if (File.Exists(p))
        return true;

    try
    {
        if (PathValidation(p))
        {
            File.Create(p+file).Close();
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

void ShowPhrases()
{
    var reader = new StreamReader(path + file);

    Console.WriteLine(reader.ReadToEnd());

    reader.Close();
}

void AddPhrase(string s)
{
    if (FileValidation(path + file))
    {
        var reader = new StreamReader(path + file);
        var phrases = new List<string>();

        while(reader.Peek() != -1)
        {
            phrases.Add(reader.ReadLine());
        }
        reader.Close();

        phrases.Add(s);


        var writer = new StreamWriter(path + file);

        foreach(string p in phrases)
        {
            writer.WriteLine(p);
        }

        writer.Close();
    }
}

void AddSimple(string s)
{
    File.AppendAllText(path + file, s);
}
int Menu()
{
    Console.WriteLine("[1] - Adicionar frase no arquivo.");
    Console.WriteLine("[2] - Mostrar frases do arquivo.");
    Console.WriteLine("[0] - Sair.");
    return int.Parse(Console.ReadLine());
}

while (true)
{
    switch (Menu())
    {
        case 1:
            Console.WriteLine("Informe sua frase desmotivacional: ");
            //AddPhrase(Console.ReadLine());
            AddSimple(Console.ReadLine());
            break;
        case 2:
            try
            {
                ShowPhrases();
            } catch(Exception e)
            {
                Console.WriteLine("Erro");
            }
            
            break;
        case 0:
            Console.WriteLine("Hasta la vista baby");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Não entendi");
            break;
    }
}


