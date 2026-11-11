//4 - Faça um programa que cria um vetor de character de 10 posições.
//Então, faça um novo vetor que armazena o character e o valor ASCII dele logo em sequencia 
//(exemplo: "Casa"->C21A34S55A11)

char[] input = preencherVetor();
char[] resultado = criarVetorAscii(input);
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

char[] criarVetorAscii(char[] input)
{
    string stringAuxiliar = "";

    for (int i = 0; i < input.Length; i++)
    {
        stringAuxiliar += input[i];
        stringAuxiliar += ((int)input[i]).ToString();
    }

    char[] novoVetor = new char[stringAuxiliar.Length];

    for(int i=0; i<novoVetor.Length; i++)
    {
        novoVetor[i] = stringAuxiliar[i];
    }

    return novoVetor;
}

void imprimirVetor(char[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);
    }
}