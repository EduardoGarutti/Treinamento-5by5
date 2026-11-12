//4 - Faça um programa que cria um vetor de char de 10 posições.
//Então, faça um novo vetor de string com o dobro de posições que armazena o char e o valor ASCII dele logo em sequencia 
//(exemplo: "Casa"->C21A34S55A11)

char[] input = preencherVetor();
string[] resultado = criarVetorAscii(input);
Console.WriteLine("Resultado do novo vetor: ");
imprimirVetor(resultado);

char[] preencherVetor()
{
    char[] novoVetor = new char[10];
    Console.WriteLine("Informe 10 characteres");
    for (int i=0;i<novoVetor.Length; i++)
    {
        novoVetor[i] = char.Parse(Console.ReadLine());
    } 
    return novoVetor;
}

string[] criarVetorAscii(char[] input)
{
    string[] novoVetor = new string[input.Length * 2];
    int aux = 0;

    for (int i = 0; i < novoVetor.Length; i++)
    {
        if(i % 2 == 0)
        {
            novoVetor[i] = input[aux].ToString();
        }
        else
        {
            novoVetor[i] = ((int)input[aux]).ToString();
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