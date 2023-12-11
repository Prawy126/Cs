using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Reviewer : Reader
    {
        public Reviewer(Osoba osoba) : base(osoba)
        {
        }
        public void Wypisz()
        {
            base.ViewBook();

        }
    }
}
