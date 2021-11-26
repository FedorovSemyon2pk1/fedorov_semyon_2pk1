using System;

namespace pz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            double a = Convert.ToDouble(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("1, 2, 3, 4, 5, 6 и 8 января — Новогодние каникулы. 7 января — Рождество Христово");
                    break;
                case 2:
                    Console.WriteLine("23 февраля — День защитника Отечества");
                    break;
                case 3:
                    Console.WriteLine("8 марта — Международный женский день");
                    break;
                case 4:
                    Console.WriteLine("Праздничные дни отсутствуют");
                    break;
                case 5:
                    Console.WriteLine("1 мая — Праздник Весны и Труда. 9 мая — День Победы");
                    break;
                case 6:
                    Console.WriteLine("12 июня — День России");
                    break;
                case 7:
                    Console.WriteLine("Праздничные дни отсутствуют");
                    break;
                case 8:
                    Console.WriteLine("Праздничные дни отсутствуют");
                    break;
                case 9:
                    Console.WriteLine("Праздничные дни отсутствуют");
                    break;
                case 10:
                    Console.WriteLine("Праздничные дни отсутствуют");
                    break;
                case 11:
                    Console.WriteLine("4 ноября — День народного единства.");
                    break;
                case 12:
                    Console.WriteLine("31 декабря - Новый Год ");
                    break;
                default:
                    Console.WriteLine("неверный формат данных");
                    break;



            }
        }
    }
}
