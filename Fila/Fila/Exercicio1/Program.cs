//No hospital "SóFaltaVoce", você foi contratado para gerenciar a ordem de atendimento do pronto-socorro.
//Essa ordem segue a seguinte regra:
//- Para cada dois atendimentos da fila prioritária, um atendimento da fila normal é executado.

//Faça um programa que gerencie essa fila usando senhas alfanumericas, exemplo:
//A fila prioritaria começa com P.
//A fila normal começa com N
//O numero que vem depois? Random.Shared.Next();
using System.ComponentModel.Design;

Fila prioritaria = new();
Fila normal = new();
int contador = 0;

menu();

void menu()
{
    bool sair = true;
    while (sair)
    {
        Console.WriteLine("===========HOSPITAL=SÓ=FALTA=VOCÊ===========");
        Console.WriteLine("[1] - Novo Paciente (Fila Prioritária)");
        Console.WriteLine("[2] - Novo Paciente (Fila Normal)");
        Console.WriteLine("[3] - Atender Paciente (Fila Prioritária)");
        Console.WriteLine("[4] - Atender Paciente (Fila Normal)");
        Console.WriteLine("[5] - Imprimir todas as senhas");
        Console.WriteLine("[6] - Sair");
        Console.WriteLine("============================================="); 
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                AdicionarPaciente(prioritaria, true);
                break;
            case 2:
                AdicionarPaciente(normal, false);
                break;
            case 3:
                AtenderPaciente(prioritaria);
                contador++;
                if(contador == 2)
                {
                    Console.WriteLine("Fila prioritária atendida duas vezes!\n" +
                        "Atendendo Fila normal...");
                    AtenderPaciente(normal);
                    contador = 0;
                }
                break;
            case 4:
                AtenderPaciente(normal);
                break;
            case 5:
                ImprimirTodasAsSenhas(prioritaria, normal);
                break;
            case 6:
                sair = false;
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;
        }
    }
}
void AdicionarPaciente(Fila f, bool isPrioridade)
{
    if (isPrioridade)
    {
        Senha s = new("P"+GerarSenha());
        f.InserirElemento(s);
    }
    else
    {
        Senha s = new("N" + GerarSenha());
        f.InserirElemento(s);
    }
    Console.WriteLine("Paciente adicionado com sucesso!");
}
void AtenderPaciente(Fila f)
{
    if (!f.FilaVazia())
    {
        Console.WriteLine("Senha do paciente: "+f.Head.Codigo);
        f.RemoverElemento();
        Console.WriteLine("Paciente atendido com sucesso!");
    }
    else
    {
        Console.WriteLine("Fila vazia!");
    }
}
void ImprimirTodasAsSenhas(Fila p, Fila n)
{
    Console.WriteLine("Fila Prioritária: ");
    p.ImprimirFila();
    Console.WriteLine("\nFila Normal");
    n.ImprimirFila();
    Console.WriteLine();

}
string GerarSenha()
{
    return Random.Shared.Next(10, 100).ToString();
}