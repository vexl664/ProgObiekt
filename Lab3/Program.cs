using System;

namespace Lab3_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1️ Tworzymy osoby
            Person p1 = new Person("Adam", "Kowalski", 30);
            Person p2 = new Person("Maria", "Nowak", 45);

            // 2️ Wyświetlamy osoby
            p1.View();
            p2.View();

            Console.WriteLine();

            // 3️⃣ Tworzymy książki
            Book b1 = new Book("C# dla początkujących", p1, 2020);
            Book b2 = new Book("Programowanie OOP", p2, 2018);

            // 4️ Wyświetlamy książki
            b1.View();
            Console.WriteLine();
            b2.View();
        }
    }
}
