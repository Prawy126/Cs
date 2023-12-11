using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Osoba
    {
        private string FirstName{ get; set;}
        private string LastName {  get; set;}
        private int Age { get; set;}

        public Osoba()
        {
        }

        public Osoba(string firstName, string lastName, int age)
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            
        }
        public Osoba(string firstName, string lastName)
        {
            LastName=lastName;
            FirstName=firstName;
        }

       

        

        public virtual void View()
        {
            Console.WriteLine("Imię: "+FirstName+"\nNazwisko: "+LastName+"\nWiek: " + Age);
        }

    }
}
