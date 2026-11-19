public class Pilha
{
    public Money? Top;

    public bool IsEmpty()
    {
        return Top is null;
    }

    public void AddElement(Money aux)
    {
        aux.Next = Top;
        Top = aux;
    }

    public void RemoveElement()
    {
        Top = Top.Next;
    }

    public void ShowStack()
    {
        Money aux = Top;
        while (aux != null)
        {
            Console.WriteLine(aux.Value);
            aux = aux.Next;
        }
    }

    public int ElementCount()
    {
        Money aux = Top;
        int count = 0;

        while (aux != null)
        {
            count++;
            aux = aux.Next;
        }

        return count;
    }
}