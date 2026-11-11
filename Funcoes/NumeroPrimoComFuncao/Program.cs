bool isPrimo(int nmr)
{
    if (nmr <= 1)
    {
        return false;
    }
    int contador = 0;

    for(int i = 1; i <= nmr; i++)
    {
        if(nmr % i == 0)
        {
            contador++;
        }
    }
    if(contador > 2)
    {
        return false;
    } else
    {
        return true;
    }
}

Console.WriteLine("Informe o numero desejado: ");

if (isPrimo(int.Parse(Console.ReadLine())))
{
    Console.WriteLine("O numero informado é primo");
} else
{
    Console.WriteLine("O numero informado não é primo");
}
