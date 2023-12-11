using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book
    {
        private string title;
        Osoba author;
        DateTime datePublication;
         

        public void View()
        {
            Console.WriteLine("Tytuł: " + title + "\nAutor: ");
            author.View();
            Console.WriteLine("Data wydania: " + datePublication.ToShortDateString());
            
        }
        public Book(string title, Osoba autor, DateTime datePublication)
        {
            this.title = title;
            this.author = autor;
            this.datePublication = datePublication;
        }

        public string Title()
        {
            return title;
        }
    }
}
