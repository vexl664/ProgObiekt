using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Zad1
{
    public class Book
    {
        // POLA / WŁAŚCIWOŚCI

        public string Title { get; set; }
        public Person Author { get; set; } 
        public int ReleaseYear { get; set; }

        // KONSTRUKTOR - uzupełnimy w następnym kroku
        public Book(string title, Person author, int releaseYear)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
        }

        // METODA View - uzupełnimy później
        public void View()
        {
            Console.WriteLine($"Tytuł: {Title}");
            Console.WriteLine($"Autor: {Author.FirstName} {Author.LastName}");
            Console.WriteLine($"Rok wydania: {ReleaseYear}");
        }
    }
}
