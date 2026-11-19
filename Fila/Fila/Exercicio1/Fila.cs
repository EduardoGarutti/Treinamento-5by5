public class Fila
{
    public Senha Head, Tail;
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

    public void InserirElemento(Senha aux)
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
            Senha aux = Head;

            while (aux != null)
            {
                if(aux.Proximo == null)
                {
                    Console.Write(aux.Codigo);
                }
                else
                {
                    Console.Write(aux.Codigo + " => ");
                }
                aux = aux.Proximo;
            }
        }
    }
}