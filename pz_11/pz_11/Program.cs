using System;
using System.Text.RegularExpressions;

namespace pz_11
{
    public class Example
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = Regex.Replace(input,
            @"(?:\b|(?<=([A-Za-z])))([A-Z][a-z]*)",
            m => string.Format(@"{0}{1}",
                   (m.Groups[1].Value.Length > 0) ? "_" : "", m.Groups[2].Value.ToLower()));
            Console.WriteLine(output);
        }
    }
}