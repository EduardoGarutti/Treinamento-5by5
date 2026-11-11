void Hello(string nome)
{
    Console.WriteLine("Hello, {0}!", nome);
}
string nome;
Console.WriteLine("Informe seu nome: ");
nome = Console.ReadLine();
Hello(nome);