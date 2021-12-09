using System;

namespace pz_13
{
    class Program
    {
        public enum Rating
        {
            cringe = 1,
            ploho = 2,
            neploh = 3,
            horosh = 4,
            megahorosh = 5
        }
        ;


        static void Main()
        {
            Console.Write("Введите оценку: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch ((Rating)a)
            {
                case Rating.cringe: Console.WriteLine($"Характеристика отметки : очень плохо"); break;
                case Rating.ploho: Console.WriteLine($"Характеристика отметки : неудовлетворительно"); break;
                case Rating.neploh: Console.WriteLine($"Характеристика отметки : удовлетворительно"); break;
                case Rating.horosh: Console.WriteLine($"Характеристика отметки : хорошо"); break;
                case Rating.megahorosh: Console.WriteLine($"Характеристика отметки : отлично"); break;
                default: Console.WriteLine("Оценка должна быть в пределах от 1 до 5!"); break;

            }
        }
    }
}