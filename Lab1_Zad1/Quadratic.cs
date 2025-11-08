using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObiekt
{
    internal class Quadratic
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Quadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficient 'a' cannot be zero for a quadratic equation.");
            }

            A = a;
            B = b;
            C = c;
        }
        public double ComputerDelta()
        {
            double delta = (B * B) - (4 * A * C);
            return delta;
        }
        public void Solve()
        {
            double delta = ComputerDelta();
            if (delta < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (delta == 0)
            {
                double root = -B / (2 * A);
                Console.WriteLine($"One real root: {root}");
            }
            else
            {
                double root1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double root2 = (-B - Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine($"Two real roots: {root1} and {root2}");
            }
        }
    }
}
