//2 - Faça um programa que leia 5 numeros inteiros e grave em um vetor. 
//Este vetor deve ser copiado para um novo vetor na sequencia inversa 
//Faça o mesmo copiando para um novo vetor os numeros pares e para outro os numeros impares
//Mostre todos os vetores.

int[] vetorNormal = new int[5];

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o numero na posição {i} do vetor");
    vetorNormal[i] = int.Parse(Console.ReadLine());
}

int decremento = vetorNormal.Length, i
for()