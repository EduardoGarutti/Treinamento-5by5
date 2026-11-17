//3 - Crie uma classe "Livro" com os atributos:
//"Titulo" e "autor" sendo string
//"Numero de paginas" sendo um inteiro positivo
//Crie um construtor que receba esses 3 valores. 
//Crie a função get para cada uma das propriedades
//Reescreva a função ToString para exibir os dados dos livros
Console.WriteLine("Quantos livros voce deseja informar?");
int qntLivros = int.Parse(Console.ReadLine());
Livro[] livro = new Livro[qntLivros];

Popularlivros();
ImprimirLivros(livro);
Livro CadastrarLivro()
{
    Console.WriteLine("Informe titulo do livro: ");
    string titulo = Console.ReadLine();

    Console.WriteLine("Informe o nome do autor do livro: ");
    string autor = Console.ReadLine();

    Console.WriteLine("Informe Numero de paginas do livro: ");
    int nmrDePaginas = int.Parse(Console.ReadLine());

    while (ValidarNumeroDePaginas(nmrDePaginas))
    {
        Console.WriteLine("O numero de paginas do livro não pode ser 0 ou negativo!");
        nmrDePaginas = int.Parse(Console.ReadLine());
    }

    return new Livro(titulo, autor, nmrDePaginas);    
}

bool ValidarNumeroDePaginas(int numeroDePaginas)
{
    if (numeroDePaginas <= 0)
    {
        return true;
    } 
    return false;
}

void Popularlivros()
{
    for (int i = 0; i < livro.Length; i++)
    {
        livro[i] = CadastrarLivro();
    }
}

void ImprimirLivros(Livro[] livro)
{
    for (int i = 0; i < livro.Length; i++)
    {
        Console.WriteLine(livro[i]);
    }
}