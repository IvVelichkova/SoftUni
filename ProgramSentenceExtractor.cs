using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string constant = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern= "[A-Z][\\w\\W]*?\b" + constant+
            "\b[\\w\\W]*?[.!?]";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
