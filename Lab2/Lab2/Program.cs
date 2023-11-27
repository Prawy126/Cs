// See https://aka.ms/new-console-template for more information
using Lab2;

Console.WriteLine("Hello, World!");
Licz[] liczenie = new Licz[] { new Licz(10), new Licz(20), new Licz(15)};
liczenie[0].Wypisz();
liczenie[1].Dodaj(2);
liczenie[1].Wypisz();
liczenie[2].Odejmowanie(2);
liczenie[2].Wypisz();
