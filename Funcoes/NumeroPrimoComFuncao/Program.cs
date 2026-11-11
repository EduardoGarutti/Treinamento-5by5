Console.WriteLine("Informe um numero: ");
int nmr = int.Parse(Console.ReadLine());

for(int i = 2; i<=nmr; i++)
{
    if (isPrimo(i))
    {
        Console.Write(i + " ");
    }
}

bool isPrimo(int nmr){

    for(int i = 2;i<nmr; i++)
    {
        if(nmr % i == 0)
        {
            return false;
        }
    }
    return true;
}