//8 - Faça um programa que, baseado no salario informado, calcule o aumento salarial de acordo com as regras a seguir: 
//até 2000R$ aumento de 15%
//entre 2000,01 e 4000 aumento de 10%
////acima de 4000 aumento de 5%

Console.WriteLine("Informe o salario: ");
float salario = float.Parse(Console.ReadLine());

int aumento = 0;

if(salario <= 2000)
{
    aumento = 15;
    salario += (salario * 15) / 100;
} else if (salario <= 4000)
{
    aumento = 10;
    salario += (salario * 10) / 100;
} else
{
    aumento = 5;
    salario += (salario * 5) / 100;
}

Console.WriteLine("Aumento de " + aumento +"%. Salario atual: "+ salario);