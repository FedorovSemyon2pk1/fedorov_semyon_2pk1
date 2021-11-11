using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace pz12
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string[] values = text.Split(new char[] { ' ' });
            int summ = 0;
            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    if (Convert.ToInt32(values[i]) == 0 || 0 / Convert.ToInt32(values[i]) == 0)
                    {
                        summ += Convert.ToInt32(values[i]);
                    }
                }
                catch
                {
                    continue;
                }
                Console.WriteLine(summ);
            }
        }
    }
}