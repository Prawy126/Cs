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
    Console.WriteLine(i);
}

//zadanie 3 tablica
//Tablica tablica = new Tablica(tab);
Dzialania dzialania = new Dzialania(tab);
dzialania.Dodaj();
dzialania.Min();
dzialania.Max();
dzialania.Iloczyn();
dzialania.Srednia();
