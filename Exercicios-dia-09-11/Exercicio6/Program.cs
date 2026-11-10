//6 - faça um programa que leia a idade de uma pessoa e classifique-o de acordo com as regras: 
//Crianças até 12 anos
//Adolescente de 13 a 17
//Adulto de 18 a 59
//Idoso 60+

Console.WriteLine("Informe a idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade <= 12)
{
    Console.WriteLine("Criança");
} else if( idade <= 17)
{
    Console.WriteLine("Adolescente");
} else if (idade <= 59)
{
    Console.WriteLine("Adulto");
} else
{
    Console.WriteLine("Idoso");
}