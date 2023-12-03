using System;

class Liczba
{
    private int[] cyfry;

    public Liczba(string liczba)
    {
        cyfry = new int[liczba.Length];
        for (int i = 0; i < liczba.Length; i++)
        {
            cyfry[i] = int.Parse(liczba[liczba.Length - 1 - i].ToString());
        }
    }

    public void Wypisz()
    {
        for (int i = cyfry.Length - 1; i >= 0; i--)
        {
            Console.Write(cyfry[i]);
        }
        Console.WriteLine();
    }

    public void Pomnoz(int mnoznik)
    {
        int przesuniecie = 0;
        int[] wynik = new int[cyfry.Length + 10]; // Dodatkowe miejsce na ewentualne przekroczenie zakresu

        for (int i = 0; i < cyfry.Length; i++)
        {
            int iloczyn = cyfry[i] * mnoznik + przesuniecie;
            wynik[i] = iloczyn % 10;
            przesuniecie = iloczyn / 10;
        }

        int pozycja = cyfry.Length;
        while (przesuniecie > 0)
        {
            wynik[pozycja++] = przesuniecie % 10;
            przesuniecie /= 10;
        }

        cyfry = new int[pozycja];
        Array.Copy(wynik, cyfry, pozycja);
    }

    public static Liczba Silnia(int n)
    {
        Liczba wynik = new Liczba("1");
        for (int i = 2; i <= n; i++)
        {
            wynik.Pomnoz(i);
        }
        return wynik;
    }
}


