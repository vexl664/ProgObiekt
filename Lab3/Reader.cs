using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Zad1
{
    public class Reader : Person
    {
        public List<Book> ReadBooks { get; set; }

        public Reader(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            ReadBooks = new List<Book>();
        }
        public void ViewBook()
        { 
            Console.WriteLine($"Książki przeczytane przez {FirstName} {LastName}:");

            if (ReadBooks.Count == 0)
            {
                Console.WriteLine("  (brak książek)");
                return;
            }

            foreach (var book in ReadBooks)
            {
                Console.WriteLine($"  - {book.Title}");
            }
        }
        public override void View()
        {
            // 1️ wyświetlamy dane osoby (czyli wywołujemy metodę z Person)
            base.View();

            Console.WriteLine(); // pusty wiersz dla czytelności

            // 2️ wyświetlamy książki tego czytelnika
            ViewBook();
        }


    }
}
