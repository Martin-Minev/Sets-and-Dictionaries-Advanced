using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (!numbers.Contains(input))
                {
                    numbers.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (numbers.Contains(input))
                {
                    numbers.Remove(input);
                }
            }

            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            foreach (var number in numbers)
            {
                char firstChar = number.ToCharArray().ElementAt(0);
                bool isDigit = char.IsDigit(firstChar);
                if (isDigit)
                {
                    vip.Add(number);
                }
                else
                {
                    regular.Add(number);
                }  
            }
            Console.WriteLine(numbers.Count);
            foreach (var v in vip)
            {
                Console.WriteLine(v);
            }
            foreach (var r in regular)
            {
                Console.WriteLine(r);
            }
        }
    }
}
