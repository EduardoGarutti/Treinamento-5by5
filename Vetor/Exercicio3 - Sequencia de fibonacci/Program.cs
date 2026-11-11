//3 - Faça um programa que leia um numero inteiro. 
//Usando esse numero, crie um vetor com essa quantidade de posições. 
//Dentro deste vetor, deve conter os itens da sequencia fibonacci até a posição informada 

Console.WriteLine("Informe um numero: ");
int nmr = int.Parse(Console.ReadLine());

int[] vetor = new int[nmr];
vetor = fibonacci(nmr);

imprimirVetor(vetor);

int[] fibonacci(int nmr)
{
    int[] novoVetor = new int[nmr];

    int a = 1, b = 0, aux = a;
    novoVetor[0] = b;

    for (int i = 1; i < nmr; i++)
    {
        novoVetor[i] = aux;
        aux = a + b;
        b = a;
        a = aux;
    }
    return novoVetor;
}
void imprimirVetor(int[] vetor)
{
    for (int i = 0; i < nmr; i++)
    {
        Console.Write(vetor[i] + " ");
    }
}