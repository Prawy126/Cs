// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using lab1;

//Zadanie 1 delta
//Delta delta = new Delta(-1, 2 , 1);
//Console.WriteLine("Delta wynosi: " + delta.LiczDelte());
//double[] tab = new double[2];
//tab = delta.LiczPierwiastki();
//Console.WriteLine("Miejsca zerowe wynoszą: " + tab[0] + " i " + tab[1]);

//Zadanie 2 kalkulator
//Kalkulator kal = new Kalkulator();


double[] tab = new double[10];
for(int i = 1; i <= tab.Length; i++)
{
    tab[i-1] = i;
    //Console.WriteLine(i);
}

//zadanie 3 tablica
//Tablica tablica = new Tablica(tab);

//zadanie4
//Dzialania dzialania = new Dzialania(tab);
//dzialania.Dodaj();
//dzialania.Min();
//dzialania.Max();
//dzialania.Iloczyn();
//dzialania.Srednia();

//zadanie 5
//Wypisywanie wypisywanie = new Wypisywanie();
//wypisywanie.WypisywanieOd20Do0();

//zadanie 6

//PetlaNieskonczona petlaNieskonczona = new PetlaNieskonczona();

//zadanie 7
Sortowanie sortowanie = new Sortowanie();
sortowanie.Wypisz();

