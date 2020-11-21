
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
            double num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;


            if (op == "+")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 + num2) + " (" + num1 + "+" + num2 + ")");
            }
            else if (op == "-")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 - num2) + " (" + num1 + "-" + num2 + ")");
            }
            else if (op == "/")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 / num2) + " (" + num1 + "/" + num2 + ")");
            }
            else if (op == "*")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 * num2) + " (" + num1 + "*" + num2 + ")");
            }


            Console.WriteLine(op + num1 + num2 );




            Console.ReadLine();
        }
    }
}