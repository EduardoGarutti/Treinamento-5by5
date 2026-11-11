//2 - Faça um programa que leia 5 numeros inteiros e grave em um vetor. 
//Este vetor deve ser copiado para um novo vetor na sequencia inversa 
//Faça o mesmo copiando para um novo vetor os numeros pares e para outro os numeros impares
//Mostre todos os vetores.

int[] vetorNormal = new int[5];
vetorNormal = preencherVetor(vetorNormal);

int[]vetorInvertido = new int[vetorNormal.Length];
vetorInvertido = inverterVetor(vetorNormal);

int[] vetorPar = new int[qntDeNumerosParOuImpar(vetorNormal,true)];
vetorPar = novoVetorParOuImpar(vetorNormal, true);

int[] vetorImpar = new int[qntDeNumerosParOuImpar(vetorNormal, false)];
vetorImpar = novoVetorParOuImpar(vetorNormal, false);

Console.WriteLine("Vetor normal: ");
imprimirVetor(vetorNormal);
Console.WriteLine("\nVetor invertido: ");
imprimirVetor(vetorInvertido);
Console.WriteLine("\nVetor com numeros pares: ");
imprimirVetor(vetorPar);
Console.WriteLine("\nVetor com numeros impares: ");
imprimirVetor(vetorImpar);

//--------------------------------------------------------------------
int[] preencherVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Informe o numero na posição {i} do vetor");
        vetor[i] = int.Parse(Console.ReadLine());
    }
    return vetor;
}

int[] inverterVetor(int[] vetor)
{
    int[] novoVetor = new int[vetor.Length];
    int decremento = vetor.Length - 1;

    for(int i = 0; i < vetor.Length; i++)
    {
        novoVetor[i] = vetor[decremento];
        decremento--;
    }
    return novoVetor;
}

int[] novoVetorParOuImpar(int[] vetor, bool isPar)
{
    int contador = qntDeNumerosParOuImpar(vetor, isPar);
    int[] novoVetor = new int[contador];
    contador = 0;

    if (isPar)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                novoVetor[contador] = vetor[i];
                contador++;
            }
        }
        return novoVetor;
    }
    else
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                novoVetor[contador] = vetor[i];
                contador++;
            }
        }
        return novoVetor;
    }
    
}

int qntDeNumerosParOuImpar(int[] vetor, bool isPar)
{
    int qntPar = 0, qntImpar = 0;

    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 == 0)
        {
            qntPar++;
        }
        else
        {
            qntImpar++;
        }
    }
    if (isPar)
    {
        return qntPar;
    } else
    {
        return qntImpar;
    }
}

void imprimirVetor(int[] vetor)
{
    for(int i = 0; i<vetor.Length; i++)
    {
        Console.Write(vetor[i] + " ");
    }
}

