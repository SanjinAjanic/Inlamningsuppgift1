
using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

             
            Console.Title = "Sanjin Inlämningsuppgift1";
            Console.BackgroundColor
           = ConsoleColor.Blue;


            List<double> result = new List<double>();
            int counter = default(int);
            bool quit = default(bool);

            do
            {

                


                Console.Write("Enter a Operator or a to quit program:");
                string op1 = Console.ReadLine();

                if (op1 == "a")
                {
                    quit = true;
                    Console.Write("Du väljer att avsluta programet");
                }
                else
                {



                    Console.Write("Enter a number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());


                    Console.Write("Enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());



                    if (op1 == "+")
                    {
                        result.Add(num1 + num2);
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} = {3}", num1, op1, num2, result[counter]);
                    }
                    else if (op1 == "-")
                    {
                        result.Add(num1 - num2);
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} = {3}", num1, op1, num2, result[counter]);
                    }
                    else if (op1 == "/")
                    {
                        result.Add(num1 / num2);
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} = {3}", num1, op1, num2, result[counter]);
                    }
                    else if (op1 == "*")
                    {
                        result.Add(num1 * num2);
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} = {3}", num1, op1, num2, result[counter]);
                    }


                }
                Console.ReadLine();

            } while (!quit);
           
            double totalSum = 0;
            foreach (var item in result)
            {
                totalSum += item;
            }

            Console.WriteLine(totalSum + " Är summan av dina beräkningar");

            

            
        }
    }
}