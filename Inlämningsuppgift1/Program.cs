﻿
using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Operator:");
            string op = Console.ReadLine();



            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());



            Console.Write("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }


            




            Console.ReadLine();
        }
    }
}