using System;

namespace ProgObiekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Powitanie 
            Console.WriteLine("Obliczanie delty");
            
            //podajemy a 
            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            //podajemy b
            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            //podajemy c
            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            //tworzymy obiekt z dannymi od użytkownika
            Quadratic trojmian = new Quadratic(a, b, c);

            //obliczamy delte
            double delta = trojmian.ComputerDelta();

            //wyświetlamy wynik gotowych wyróżników 
            Console.WriteLine($"Wyróżnik (delta) = {delta}");

            // Obliczamy pierwiastki
            trojmian.Solve();
        }

    }
}
