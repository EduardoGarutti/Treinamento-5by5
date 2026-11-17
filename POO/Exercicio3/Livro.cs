public class Livro
{
    public string Titulo, Autor;
    public int NumeroDePaginas;

    public Livro(string Titulo, string Autor, int NumeroDePaginas)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.NumeroDePaginas = NumeroDePaginas;
    }

    public void setTitulo(string Titulo)
    {
        this.Titulo = Titulo;
    }

    public string getTitulo()
    {
        return Titulo;
    }

    public void setAutor(string Autor)
    {
        this.Autor= Autor;
    }

    public string getAutor()
    {
        return Autor;
    }

    public void setNumeroDePaginas(int NumeroDePaginas)
    {
        this.NumeroDePaginas= NumeroDePaginas;
    }

    public int getNumeroDePaginas()
    {
        return NumeroDePaginas;
    }

    public override string ToString()
    {
        return "Livro: "+Titulo+
            "\nAutor: "+Autor+
            "\nNumero de Paginas: "+NumeroDePaginas;
    }
}
