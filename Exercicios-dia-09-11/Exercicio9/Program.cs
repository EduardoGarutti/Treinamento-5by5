//9 - Faça um programa que receba o valor de 3 lados de um triangulo e informe o tipo do triangulo (Equilatero, isosceles e escaleno).
//Obs: os lados informados devem formar um triangulo

Console.WriteLine("informe 3 lados de um triangulo: ");
float lado1 = float.Parse(Console.ReadLine());
float lado2 = float.Parse(Console.ReadLine());
float lado3 = float.Parse(Console.ReadLine());

if ((lado1 + lado2) < lado3)
{
    Console.WriteLine("A soma de " + lado1 + " e " +
        lado2 + " é menor que " + lado3 + ", não forma um triangulo");
    return;
}

if ((lado2 + lado3) < lado1)
{
    Console.WriteLine("A soma de " + lado2 + " e " +
        lado3 + " é menor que " + lado1 + ", não forma um triangulo");
    return;

}

if ((lado1 + lado3) < lado2)
{
    Console.WriteLine("A soma de " + lado1 + " e " +
        lado3 + " é menor que " + lado2 + ", não forma um triangulo");
    return;
}

if (lado1 == lado2 && lado1 == lado3)
{
    Console.WriteLine("É um triangulo equilatero");
} else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("Triangulo Isoceles");
} else
{
    Console.WriteLine("Triangulo escaleno");
}

