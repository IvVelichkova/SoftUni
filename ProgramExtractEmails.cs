using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string pattern = @"^(([a-z]|[0-9])+([a-zA-Z0-9\d.\d_\d-]+)@(\w+[a-z.]+[a-z]))\$";

            Regex regex = new Regex(@"\b(([a-z]|[0-9])([a-zA-Z0-9\d.\d_\d-]+)@(\w+[a-z.-]+[a-z]))\b");

            MatchCollection matches = regex.Matches(input);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[1]);
            }
        }
    }
}
