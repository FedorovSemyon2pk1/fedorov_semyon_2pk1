using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 17, 75, 769 }, { 22, 16, 504 }, { 19, 72, 53 } ,{1147, 82 ,3 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                Console.Write(sum + " ");
            }
        }
    }
}

