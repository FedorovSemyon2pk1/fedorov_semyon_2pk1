using System;

namespace пз6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -4;

            while (x > -4.5 && x < 4.5)
            {
                double y = Math.Abs(x);
                x += 0.5;
                Console.WriteLine(y);
            }
        }
    }
}
