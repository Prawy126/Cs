using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        private int value;
        public int Dodaj(int value)
        {
            return this.value += value;
        }
        public int Odejmowanie(int value)
        {
            return this.value -= value;
        }
        public Licz(int value)
        {
            this.value = value;
        }
        public void Wypisz()
        {
            Console.WriteLine("Wartość zmiennej value wynosi " + this.value);
        }
    }
}
