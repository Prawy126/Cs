using System;
using System.Linq;

namespace lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            try
            {
                try
                {
                    Zadanie1 zadanie1 = new Zadanie1(null);
                    Console.WriteLine(zadanie1.Dlugosc());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw new Exception("Wystąpił wyjątek", e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Zadanie 2");
            try
            {
                Losowanie losowanie = new Losowanie();
            }catch(ArithmeticException e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }catch(StackOverflowException e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Zadanie 3");

            SomeClass someClass = new SomeClass();
            for(int i = 0; i < 5; i++)
            {
                try
                {
                    someClass.CanThroException();
                
                }catch(Exception e)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Zadanie 4");

            Osoba osoba1 = new Osoba("Michał", "Pilecki", 20);
            Kopiuj k = new Kopiuj(osoba1);
            Osoba osoba2 = k.Tworz();
            Console.WriteLine("Osoba stworzona : " + "Imie: " + osoba1.GetImie() + " Nazwisko: " + osoba1.GetNazwisko() + " Wiek: " + osoba1.GetWiek());
            Console.WriteLine("Osoba skopiowana ale nie powielona referencja : " + "Imie: " + osoba2.GetImie() + " Nazwisko: " + osoba2.GetNazwisko() + " Wiek: " + osoba2.GetWiek());

            //dokończyć zadanie 5 i 6
        }
    }
}