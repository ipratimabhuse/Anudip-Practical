using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpression2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string email = "pratimabhuse@gmail.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine("is valid:{0}", result);
            Console.ReadLine();
        }
    }
}
