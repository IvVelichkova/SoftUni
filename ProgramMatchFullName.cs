using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b^[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
            string userName = Console.ReadLine();


            while (userName!="end")
            {

                var regex = new Regex(pattern);

                if (regex.IsMatch(userName))
                {
                    Console.WriteLine(userName);
                }

                userName = Console.ReadLine();

            }




        }
    }
}

