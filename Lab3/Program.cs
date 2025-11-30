using System;
using System.ComponentModel.Design;

namespace Lab3_Zad1
{
    internal class Program
    {
        static void Main(string[] args)   // potrzebne do wy
        {
            // === KSIĄŻKI ===
            Book b1 = new Book("C# dla początkujących", new Person("Adam", "Kowalski", 30), 2020);
            Book b2 = new Book("Programowanie obiektowe", new Person("Maria", "Nowak", 40), 2018);
            Book b3 = new Book("Algorytmy w praktyce", new Person("Jan", "Wiśniewski", 50), 2015);
            Book b4 = new Book("Bazy danych", new Person("Kasia", "Mazur", 28), 2022);

            // === CZYTELNICY ===
            Reader r1 = new Reader("Paweł", "Nowak", 20);
            Reader r2 = new Reader("Ola", "Kowalczyk", 25);

            // Przypisujemy książki
            r1.ReadBooks.Add(b1);
            r1.ReadBooks.Add(b2);

            r2.ReadBooks.Add(b2);
            r2.ReadBooks.Add(b3);
            r2.ReadBooks.Add(b4);

            // Wyświetlamy

            r1.View();
            Console.WriteLine();
            r2.View();
        }
    }
}
