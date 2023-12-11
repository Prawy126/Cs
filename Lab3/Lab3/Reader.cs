using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Reader : Osoba
    {
        List<Book> books { get; set; }
        Osoba osoba;
        public Reader(Osoba osoba)
        {
            books = new List<Book>();
            this.osoba = osoba;
            
        }
       
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewBook()
        {
            foreach (Book book in books)
            {
                
                Console.WriteLine(book.Title());
                
            }
        }
        public override void View()

        {
            base.View();
            foreach (Book item in books)
            {
                ViewBook();
               Console.WriteLine("---------------------------------------------------");
            }
        }

    }
}
