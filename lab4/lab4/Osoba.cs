using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Osoba
    {
        string imie, nazwisko;
        string  pesel;

        public void SetName(string imie)
        {
            this.imie = imie;
        }
        public void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }
        public int GetAge()
        {
            int year = int.Parse(1900 + pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }
    }
}
