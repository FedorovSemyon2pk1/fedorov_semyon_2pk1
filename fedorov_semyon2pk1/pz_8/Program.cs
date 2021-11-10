using System;
using System.Linq;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Console.WriteLine("Массив А: ");
            Random rnd = new Random();
            int i;
            for (i = 0; i <= (9); i++) 
            {
                A[i]=rnd.Next(0, 10);
                Console.Write(" " + A[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] uniq = A.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).ToArray();
            foreach (int x in uniq )
            {
                Console.Write(" " + x) ;
            }

        }
    }
}
