using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Zadanie3
    {
        DateOnly today;
        
        public Zadanie3()
        {
            today = DateOnly.FromDateTime(DateTime.Now);
            
        }
        public void WypiszDate()
        {
            Console.WriteLine(today.ToString());
            
        }
        public void PrzesunDzien(int dzien)
        {
            today = today.AddDays(dzien);
            
        }
        public void PrzesunRok(int rok)
        {
            today = today.AddYears(rok);
            
        }
        public void PrzesunMiesiac(int miesiac) 
        { 
            today = today.AddMonths(miesiac);
            
        }
    }
}
