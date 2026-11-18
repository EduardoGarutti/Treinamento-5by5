public class Fila
{
    public Pessoa Head, Tail;
    public int Contador;

    public Fila()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null)
            return true;
        return false;
    }

    public void InserirElemento(Pessoa aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Proximo = aux;
            Tail = aux;
        }
        Contador++;
    }

    public int GetContador()
    {
        return Contador;
    }

    public void RemoverElemento()
    {
        if (!FilaVazia())
        {
            if (Head.Proximo == null)
                Tail = Tail.Proximo;
            Head = Head.Proximo;
            Contador--;
        }
    }

    public void ImprimirFila()
    {
        if (!FilaVazia())
        {
            Pessoa aux = Head;

            while (aux != null)
            {
                Console.WriteLine(aux.Nome+"\n");
                aux = aux.Proximo;
            } 
        }
    }
}