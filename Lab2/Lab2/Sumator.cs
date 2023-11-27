using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        private  int[] liczby = new int[10];
        public Sumator()
        {

        }
        public int Suma()
        {
            int suma = 0;
            for(int i = 0; i < 10; i++)
            {
                suma += liczby[i];
            }
            return suma;
        }
        public int SumaPodziel2()
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                if(suma%2==0)
                suma += liczby[i];
            }
            return suma;
        }
        public int IleElementow()
        {
            return liczby.Length;
        }
        public void Wypisz()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
