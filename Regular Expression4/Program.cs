﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expression4
{
    class Program
    {
        static void Main(string[] args)
        {
            string regularExpression = @"^(?=.*\d)(?=.*\w)[\d\w+]{8,20}$";
            Console.WriteLine("Please input password for check:");
            string inputString = Console.ReadLine();
            if (inputString != "" && Regex.IsMatch(inputString, regularExpression))
            {
                Console.WriteLine("It's correct security password");
            }
            else
            {
                Console.WriteLine("It's incorrect Security Password.");
            }
            Console.Read();
        }
    }
}
