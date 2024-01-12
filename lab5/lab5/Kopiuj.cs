using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Kopiuj
    {
        private string imie, nazwisko;
        private int wiek;
        public Kopiuj(Osoba osoba) 
        { 
            imie = osoba.GetImie();
            nazwisko = osoba.GetNazwisko();
            wiek = osoba.GetWiek();
        }
        public Osoba Tworz() 
        {
            return new Osoba(this.imie, this.nazwisko, this.wiek);
        }
    }
}
