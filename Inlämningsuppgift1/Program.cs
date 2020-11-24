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


            Console.Clear();

            List<double> result = new List<double>();
            int counter = 0;
            bool quit = false;


            do
            {




                Console.Write("Enter an Operator or NO to quit program:");
                string op1 = Console.ReadLine();

                if (op1.ToLower() == "no")
                {
                    quit = true;
                    Console.Write("Du väljer att avsluta programet");
                }
                else
                {

                    Console.Write("Enter secound Operator:");
                    string op2 = Console.ReadLine();


                    Console.Write("Enter a number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());




                    Console.Write("Enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter thrd number:");
                    double num3 = Convert.ToDouble(Console.ReadLine());





                    if (op1 == "+")
                    {


                        if (op2 == "+")
                        {
                            result.Add(num1 + num2 + num3);
                        }
                        else if (op2 == "-")
                        {
                            result.Add(num1 + num2 - num3);
                        }
                        else if (op2 == "*")
                        {
                            result.Add(num1 + num2 * num3);
                        }
                        else if (op2 == "/")
                        {
                            result.Add(num1 + num2 / num3);
                        }
                        else
                        {
                            Console.WriteLine("Operator two is a invalid operator");
                        }
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", num1, op1, num2, op2, num3, result[counter]);

                    }
                    else if (op1 == "-")
                    {
                        if (op2 == "+")
                        {
                            result.Add(num1 - num2 + num3);
                        }
                        else if (op2 == "-")
                        {
                            result.Add(num1 - num2 - num3);
                        }
                        else if (op2 == "*")
                        {
                            result.Add(num1 - num2 * num3);
                        }
                        else if (op2 == "/")
                        {
                            result.Add(num1 - num2 / num3);
                        }
                        else
                        {
                            Console.WriteLine("Operator two is a invalid operator");
                        }
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", num1, op1, num2, op2, num3, result[counter]);

                    }
                    else if (op1 == "*")
                    {
                        if (op2 == "+")
                        {
                            result.Add(num1 * num2 + num3);
                        }
                        else if (op2 == "-")
                        {
                            result.Add(num1 * num2 - num3);
                        }
                        else if (op2 == "*")
                        {
                            result.Add(num1 * num2 * num3);
                        }
                        else if (op2 == "/")
                        {
                            result.Add(num1 * num2 / num3);
                        }
                        else
                        {
                            Console.WriteLine("Operator two is a invalid operator");
                        }
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", num1, op1, num2, op2, num3, result[counter]);
                    }
                    else if (op1 == "/")
                    {
                        if (op2 == "+")
                        {
                            result.Add(num1 / num2 + num3);
                        }
                        else if (op2 == "-")
                        {
                            result.Add(num1 / num2 - num3);
                        }
                        else if (op2 == "*")
                        {
                            result.Add(num1 / num2 * num3);
                        }
                        else if (op2 == "/")
                        {
                            result.Add(num1 / num2 / num3);
                        }
                        else
                        {
                            Console.WriteLine("Operator two is a invalid operator");
                        }
                        counter = result.Count - 1;

                        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", num1, op1, num2, op2, num3, result[counter]);
                    }
                    else
                    {
                        Console.WriteLine("Operator one is a invalid operator");

                    }






                    double totalSum = 0;
                    foreach (var item in result)
                    {
                        totalSum += item;
                    }


                    if (totalSum < 100)
                    {
                        Console.WriteLine("Less then a hundred");
                    }
                    else if (totalSum > 100)
                    {
                        Console.WriteLine("More then a hundred");
                    }
                    else if (totalSum == 100)
                    {
                        Console.WriteLine("Cool, now you have a hundred, clap clap");
                    }
                }
            } while (quit == false);
        }
    }
}
