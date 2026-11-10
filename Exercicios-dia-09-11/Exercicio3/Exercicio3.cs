/*3 - Faça um programa que receba 4 notas de um aluno. Calcule a média aritimetica e informe o estado do aluno baseado nas seguintes condições:
aprovado se a média for maior ou igual a 7. Recuperação se a média for entre 5.1 e 6.9. Reprovado se a média for menor ou igual a 5*/

Console.WriteLine("Informe as 4 notas do aluno em sequencia: ");
float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());
float nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4) / 4;

if(media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
} else if (media > 5)
{
    Console.WriteLine("Aluno em recuperação!");
} else
{
    Console.WriteLine("Aluno reprovado!");
}
