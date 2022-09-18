using System.Text.RegularExpressions;
using System;

namespace _100Days.ConsoleApp
{
    public class Pattern
    {
        public Pattern(string input)
        {
            Regex re = new Regex("([a-z][a-z0-9]{2,})[@]([a-z]{3,})[.]([a-z]{2,})");

            Console.WriteLine("");
          
            if (re.IsMatch(input))  Console.WriteLine("email valid");
            else    Console.WriteLine("email NOT valid");

        }
        
    }
}



