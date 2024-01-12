internal class Zadanie1
{
    private string tekst;

    public Zadanie1(string tekst)
    {
        if (tekst == null)
        {
            throw new ArgumentNullException(nameof(tekst), "Napis nie może być null");
        }
        this.tekst = tekst;
    }

    public int Dlugosc()
    {
        int liczbaSpacji = tekst.Count(znak => znak == ' ');
        int dlugosc = tekst.Length - liczbaSpacji;
        return dlugosc;
    }
}