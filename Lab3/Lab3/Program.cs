
using Lab3;
class Program
{
    static void Main(string[] args)
    {
        if (false)
        {
            MainA1(args);
        }
        else if (false)
        {
            MainB1(args);
        }
        else if(false)
        {
            MainD1(args);
        }else if (true)
        {
            Main2(args);
        }
    }
    static void MainA1(string[] args)
    {
        Osoba[] osoba = new Osoba[] {
    new Osoba("Jan","Nowak",12),
    new Osoba("Michał","Wiśniewski",32),
    new Osoba("Andrzej","Duda",51),
    new Osoba("Jan","Kowalski",31)
};
        //osoba[1].View();
        Osoba[] osoba1 = new Osoba[] {
    new Osoba("Jan","Nowak"),
    new Osoba("Michał","Wiśniewski"),
    new Osoba("Andrzej","Duda"),
    new Osoba("Jan","Kowalski")
};

        Book[] books = new Book[]
        {
    new Book("W pustynii i w puszczy",osoba1[1],new DateTime(1999,12,21)),
        };

        books[0].View();

    }
    public static void MainB1(string[] args)
    {
        Osoba osoba = new Osoba("Jan", "Michałek");
        Book book = new Book("W pustynii i w puszczy", osoba, new DateTime(1999, 12, 21));
        Book book1 = new Book("W pustynii", osoba, new DateTime(1999, 12, 11));
        Reader reader1 = new Reader(osoba);
        reader1.AddBook(book1);
        reader1.AddBook(book);
        reader1.View();
    }
    public static void MainD1(string[] args)
    {
        Osoba o = new Reader(new Osoba("Michał", "Pilecki"));
        o.View();
    }
    public static void Main2(string[] args)
    {
        SamochoOsobowy samochod = new SamochoOsobowy("FSO Polonez", "Polonez", "4X4", "Czarny", 1978, 21343.431f,2.4f,1.6f,4);
        samochod.PokazInformacje();
        Console.WriteLine("---------------------------------------");
        Samochod samochod1 = new Samochod("Mercedes", "CLA");
        samochod1.PokazInformacje();
        Console.WriteLine("---------------------------------------");
        Samochod samochod2 = new Samochod("FSO Polonez", "Polonez", "4X4", "Czarny", 1978, 21343.431f);
        samochod2.PokazInformacje();
    }

}

