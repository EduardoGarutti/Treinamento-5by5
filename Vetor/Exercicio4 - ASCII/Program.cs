//4 - Faça um programa que cria um vetor de string de 10 posições.
//Então, faça um novo vetor que armazena a strng e o valor ASCII dele logo em sequencia 
//(exemplo: "Casa"->C21A34S55A11)

string[] input = preencherVetor();
string[] resultado = criarVetorAscii(input);
Console.WriteLine("Resultado do novo vetor: ");
imprimirVetor(resultado);

string[] preencherVetor()
{
    string[] novoVetor = new string[10];
    Console.WriteLine("Informe 10 characteres");
    for (int i=0;i<novoVetor.Length; i++)
    {
        novoVetor[i] = Console.ReadLine();
    } 
    return novoVetor;
}

string[] criarVetorAscii(string[] input)
{
    string[] novoVetor = new string[input.Length * 2];
    int aux = 0;

    for (int i = 0; i < novoVetor.Length; i++)
    {
        if(i % 2 == 0)
        {
            novoVetor[i] = input[aux];
        }
        else
        {
            novoVetor[i] = ((int)Convert.ToChar(input[aux])).ToString();
            aux++;
        }
    }
    return novoVetor;
}

void imprimirVetor(string[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]+ " ");
    }
}