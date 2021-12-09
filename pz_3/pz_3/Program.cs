using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите h: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            double x = Double.Parse(Console.ReadLine());

            double s = 0, p = 0;
            if (h > 3)
            {
                s = h * (Math.Cos(Math.Sqrt(a + h)));

            }

            else if (h <= 3)
            {
                s = h * (Math.Sin(a + 3.14));

            }
            Console.WriteLine(s);
            if (x <= 0.7)
            {
                p = (Math.Pow(h, 2)) + (4 * Math.Sin(a + x)) + x;

            }
            else if (x > 0.7)
            {
                p = (Math.Exp(a - s)) + Math.Pow(x, 2) - h;

            }
            Console.WriteLine(p);
            double z = (0.1 * (Math.Pow(h, 3))) - (0.3 * s * (Math.Pow(p, 3)));
            Console.WriteLine(z);
        }
    }
}