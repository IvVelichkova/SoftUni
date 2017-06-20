using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceAtag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(<a) (\w+=""http:\/\/softuni.bg"">SoftUni)(<\/a>)";
            string replacement = " ";
            while (input!="end")
                
            {
                var regex = new Regex(pattern);
                Console.WriteLine();



                    

                input = Console.ReadLine();
            }
        }
    }
}
