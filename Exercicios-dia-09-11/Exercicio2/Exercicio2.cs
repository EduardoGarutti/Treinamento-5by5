//2- escreva um programa que informa dois numeros decimais e informe se eles são maior, menor ou iguais

Console.WriteLine("informe dois numeros decimais: ");

float numero1 = float.Parse(Console.ReadLine());
float numero2 = float.Parse(Console.ReadLine());

if(numero1 > numero2)
{
    Console.WriteLine("Numero 1 é maior que o numero 2!");
} else if(numero1 < numero2)
{
    Console.WriteLine("Numero 2 é maior que o numero 1!");
} else
{
    Console.WriteLine("os numeros são iguais!");
}
