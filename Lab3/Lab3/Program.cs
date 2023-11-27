// See https://aka.ms/new-console-template for more information
using Lab3;

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