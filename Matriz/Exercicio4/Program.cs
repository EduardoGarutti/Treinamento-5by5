//4 - Faça um programa que gere o boletim escolar de um aluno. Critérios:
//As linhas são as matérias.
//As colunas são as notas de cada bimestre + a média e a situação do aluno em cada matéria

Console.WriteLine("Quantas materias deseja informar?: ");
int qntMaterias = int.Parse(Console.ReadLine());
string[,] boletim = new string[qntMaterias, 7];
InformarMaterias(boletim, qntMaterias);
InformarNotasEGerarBoletim(boletim, qntMaterias);
ImprimirBoletim(boletim, qntMaterias);

void InformarMaterias(string[,] matriz, int linhas)
{
    for(int i = 0;i<linhas; i++)
    {
        Console.WriteLine($"Informe materia {i+1}: ");
        matriz[i, 0] = Console.ReadLine();
    }
}

void InformarNotasEGerarBoletim(string[,] matriz, int linhas)
{
    float[] notas = new float[4]; 
    float media;

    for(int i=0; i < linhas; i++)
    {
        for(int j=1; j<5; j++)
        {
            Console.WriteLine($"Informe Nota {j} de {matriz[i,0]}: ");
            notas[j-1] = float.Parse(Console.ReadLine());
            matriz[i,j] = notas[j-1].ToString();
        }
        media = GerarMedia(notas);

        matriz[i,5] = media.ToString();

        matriz[i, 6] = GerarSituacao(media);
    }
}

float GerarMedia(float[] notas)
{
    float aux=0;
    for(int i=0; i<notas.Length; i++)
    {
        aux += notas[i];
    }
    return aux / 4;
}

string GerarSituacao(float media)
{

    if (media >= 7)
    {
        return "Aprovado";
    }
    else if (media > 5)
    {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

void ImprimirBoletim(string[,] boletim, int linhas)
{
    Console.WriteLine("  Matérias    Nota 1\tNota 2\tNota 3\tNota 4\tMédia\tSituação");
    for(int i = 0; i < linhas; i++)
    {
        Console.Write("\t");
        for(int j=0; j<7; j++)
        {
            Console.Write(boletim[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}