using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Sortowanie
    {
        private bool dziala = true;
        private string wartosc;
        ArrayList lista = new ArrayList();
        public Sortowanie() 
        {
            Console.WriteLine("Podaj wartość na koniec podaj napisz koniec");
            while (dziala)
            {
                Console.WriteLine("Podaj wartość:");
                wartosc = Console.ReadLine();
                if(wartosc.Equals("koniec"))
                {
                    dziala = false;
                    continue;
                }
                int i = int.Parse(wartosc);
                lista.Add(i);
            }
            lista.Sort();

        }
        public void Wypisz()
        {
            foreach(var a in lista)
            {
                Console.WriteLine(a);
            }
        }
    }
}
