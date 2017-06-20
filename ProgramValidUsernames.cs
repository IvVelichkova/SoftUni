using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            ///”, “\”, “(“, “)”.
            string[] users = Console.ReadLine()
                .Split(new[] { ' ', '\\', '(', ')', '/', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> validUser = isValid(users);
            userPrint(validUser);

        }

        private static void userPrint(List<string> validation)
        {
            int max = int.MinValue;
            string max1 = "";
            string maxUser = "";
            int count = 0;
            for (int i = 0; i < validation.Count; i++)
            {

                if (validation[i].Length > max)
                {
                    max = validation[i].Length;
                    maxUser = validation[i];
                    count = i;
                }


            }
            for (int i = 1; i < validation.Count - 1; i++)
            {

                if (i == count && i != validation.Count - 1)
                {
                    string first = maxUser;
                    string prev = validation[count - 1];
                    string next = validation[count];
                    int maxx = first.Length + prev.Length;
                    if (max < first.Length + next.Length)
                    {
                        
                        Console.WriteLine(first);
                        Console.WriteLine(validation[i + 1]);
                        
                    }
                }
                if (i == count && i == validation.Count-1)
                {
                    string first = maxUser;
                    string prev = validation[count - 1];
                    string next = validation[count];
                    int maxx = first.Length + prev.Length;
                    if (max < first.Length + next.Length)
                    {
                        Console.WriteLine(first);
                        Console.WriteLine(validation[i-1]);
                        
                    }
                }
            }

        }

        public static List<string> isValid(string[] username)
        {
            string patterna = (@"^([a-z]{1}[a-zA-Z0-9_]{2,24})$");

            List<string> valid = new List<string>();
            for (int i = 0; i < username.Length; i++)
            {

                string us = username[i];
                Regex regex = new Regex(patterna);
                Match match = regex.Match(us);
                if (match.Success)
                {

                    valid.Add(us);
                }
            }
            return valid;


        }
    }
}
