//7- Faça um programa que receba o peso em kgs e a altura em cm de uma pessoa e calcule o IMC. Com base no resultado, exiba a faixa correspondente


Console.WriteLine("Informe seu peso em KG: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura em cm: ");
float alturaEmCm = float.Parse(Console.ReadLine());

float alturaEmMetros = alturaEmCm / 100;

float imc = peso / (alturaEmMetros * alturaEmMetros);

if(imc < 18.5){
    Console.WriteLine("Baixo Peso");
} else if (imc < 25)
{
    Console.WriteLine("Peso normal");
} else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
} else if (imc < 35){
    Console.WriteLine("obesidade I");
} else if (imc < 40)
{
    Console.WriteLine("Obesidade II");
} else
{
    Console.WriteLine("Obesidade III");
}

