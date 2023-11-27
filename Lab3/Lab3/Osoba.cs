using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Osoba
    {
        string firstName, lastName;
        int age;

        public Osoba()
        {
        }

        public Osoba(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            
        }
        public Osoba(string firstName, string lastName)
        {
            this.lastName=lastName;
            this.firstName=firstName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        

        public void View()
        {
            Console.WriteLine("Imię: "+firstName+"\nNazwisko: "+lastName+"\nWiek: " + age);
        }

    }
}
