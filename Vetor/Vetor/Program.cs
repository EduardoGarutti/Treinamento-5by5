int[] numero = new int[4];
int i;
void popularVetor()
{
    i = 0;
    do
    {
        Console.WriteLine($"informe o numero desejado na posição {i}");
        numero[i] = int.Parse(Console.ReadLine());
        i++;
    } while (i < numero.Length);
}

void mostrarVetor()
{
    i = 0;
    while( i < numero.Length)
    {
        Console.Write($"[{numero[i]}]");
        i++;
    }
}

popularVetor();
mostrarVetor();