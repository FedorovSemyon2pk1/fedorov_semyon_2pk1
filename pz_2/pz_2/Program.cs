using System;

namespace pz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            {
                double g = Math.Pow(Math.Abs(Math.Pow(a, 2.00) + Math.Pow(b, 2.00) - (2.20 * c)), (1.00 / 3.00));

                double result = (Math.Pow((1 / 10), 3) * Math.Tan(-8.00)) - ((a - c) * ((a * a) + (b * b))) / (g - (g * 2)) - ((Math.Cos(2.00 * a)) / Math.Sin(5.00));

                Console.WriteLine(result);
            }
        }
    }
}