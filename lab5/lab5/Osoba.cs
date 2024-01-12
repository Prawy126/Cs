using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Osoba
    {
        public string imie, nazwisko;
        public int wiek;
        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public int GetWiek()
        {
            return this.wiek;
        }
        public string GetNazwisko()
        {
            return this.nazwisko;
        }
        public string GetImie() 
        {
            return this.imie;
        }
    }
}
