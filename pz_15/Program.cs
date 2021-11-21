using System;
using System.IO;
using System.Text;
namespace пз_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = File.ReadAllText(@"C:\Users\ильнур\Desktop\алга\f1.txt", Encoding.UTF8);
            string f2 = File.ReadAllText(@"C:\Users\ильнур\Desktop\алга\f2.txt", Encoding.UTF8);
            File.WriteAllText(@"C:\Users\ильнур\Desktop\алга\h.txt", f1, Encoding.UTF8);
            File.WriteAllText(@"C:\Users\ильнур\Desktop\алга\f2.txt",
            File.ReadAllText(@"C:\Users\ильнур\Desktop\алга\h.txt", Encoding.UTF8),
            Encoding.UTF8);
            File.WriteAllText(@"C:\Users\ильнур\Desktop\алга\f1.txt", f2, Encoding.UTF8);

        }


    }
}