
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
            int num1 = Convert.ToInt32(Console.ReadLine());



            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

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