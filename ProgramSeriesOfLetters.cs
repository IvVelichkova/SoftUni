using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"([a-zA-Z0-9])\1*");

            MatchCollection match = regex.Matches(text);

            foreach (Match m in match)
            {
                string str = m.Groups[1].ToString();
                Console.Write(str);

            }
            Console.WriteLine();

        }
    }
}
