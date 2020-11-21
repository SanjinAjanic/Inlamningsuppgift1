
using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Operator:");
            string op1 = Console.ReadLine();

            Console.Write("Enter secound Operator:");
            string op2 = Console.ReadLine();

            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;


            if (op1 == "+")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 + num2) + " (" + num1 + "+" + num2 + ")");
            }
            else if (op1 == "-")
            {
                Console.WriteLine("Resultatet är: " +  (result = num1 - num2) + " (" + num1 + "-" + num2 + ")");
            }
            else if (op1 == "/")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 / num2) + " (" + num1 + "/" + num2 + ")");
            }
            else if (op1 == "*")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 * num2) + " (" + num1 + "*" + num2 + ")");
            }
           
            if (op2 == "+")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 + num2) + " (" + num1 + "+" + num2 + ")");
            }
            else if (op2 == "-")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 - num2) + " (" + num1 + "-" + num2 + ")");
            }
            else if (op2 == "/")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 / num2) + " (" + num1 + "/" + num2 + ")");
            }
            else if (op2 == "*")
            {
                Console.WriteLine("Resultatet är: " + (result = num1 * num2) + " (" + num1 + "*" + num2 +  ")");
            }



            Console.WriteLine(op1 + op2 + num1 + num2 );




            Console.ReadLine();
        }
    }
}