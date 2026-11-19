Pilha p = new();
PopulaPilha(p);
void PopulaPilha(Pilha pilha)
{
    for (int i = 0; i < 10; i++)
    {
        switch (Random.Shared.Next(1, 7))
        {
            case 1:
                pilha.AddElement(new(2));
                break;
            case 2:
                pilha.AddElement(new(5));
                break;
            case 3:
                pilha.AddElement(new(10));
                break;
            case 4:
                pilha.AddElement(new(20));
                break;
            case 5:
                pilha.AddElement(new(50));
                break;
            case 6:
                pilha.AddElement(new(100));
                break;
        }
    }
}
p.ShowStack();
Console.WriteLine("Quantidade de elementos: " + p.ElementCount());

Thread.Sleep(1000);
Console.Clear();
while(p.ElementCount() > 0)
{
    p.RemoveElement();
    p.ShowStack();
    Thread.Sleep(1000);
    Console.Clear();
}