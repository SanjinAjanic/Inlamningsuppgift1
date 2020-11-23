
using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Operator:");
            string op1 = Console.ReadLine();

            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            List<double> result = new List<double>();
            int counter = default(int);

            if (op1 == "+")
            {
                result.Add(num1 + num2);
                counter = result.Count - 1;
                //console.writeline("resultatet är: " + (result = num1 + num2) + " (" + num1 + "+" + num2 + ")");
                Console.WriteLine("{0} {1} {2} = {3}", num1, op1, num2, result[counter]);
            }
            //else if (op1 == "-")
            //{
            //    Console.WriteLine("Resultatet är: " +  (result = num1 - num2) + " (" + num1 + "-" + num2 + ")");
            //}
            //else if (op1 == "/")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 / num2) + " (" + num1 + "/" + num2 + ")");
            //}
            //else if (op1 == "*")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 * num2) + " (" + num1 + "*" + num2 + ")");
            //}
           
            //if (op2 == "+")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 + num2) + " (" + num1 + "+" + num2 + ")");
            //}
            //else if (op2 == "-")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 - num2) + " (" + num1 + "-" + num2 + ")");
            //}
            //else if (op2 == "/")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 / num2) + " (" + num1 + "/" + num2 + ")");
            //}
            //else if (op2 == "*")
            //{
            //    Console.WriteLine("Resultatet är: " + (result = num1 * num2) + " (" + num1 + "*" + num2 +  ")");
            //}



            




            Console.ReadLine();
        }
    }
}