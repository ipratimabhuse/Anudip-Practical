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
            string str = "Hi,welcome@DotNet.com";

            string result = Regex.Replace(str, "[^a-zA-Z0-9_]+", " ");
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}

