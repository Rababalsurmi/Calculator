using System;
using System.IO;
using System.Diagnostics;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = 0;

            switch (op)
            {
                case "a":
                     Add(num1, num2);
                    break;
                case "s":
                    Subtract(num1, num2);
                    break;
                case "m":
                     Multiply(num1, num2);
                    break;
                case "d":
                     Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }
            return result;
        }
        public static double GetNumberFromUser()
        {
            double userInput = 0;
            bool succeeded = false;

            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);

            }
            return userInput;
        }

        public static double Add(double num1, double num2)
        {
            double result;
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            //Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Add(double num1, double num2, params double[] n)
        {
            double result;

            result = num1 + num2;
            //Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
            if (n != null)
            {
                foreach (int i in n)
                {
                    
                    Console.WriteLine($"Your result: " + (result += i)); 
                }
            }
            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result;
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            //Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Subtract(double num1, double num2, params double[] n)
        {
            double result;
            result = num1 - num2;
            //Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            //Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
            if (n != null)
            {
                foreach (int i in n)
                {
                    Console.WriteLine($"Your result: " + (result -= i));
                }
            }
            return result;
        }

        public static double Multiply(double num1, double num2)
        {
            double result;
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            //Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            double result;
            result = num1 / num2;
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                Console.WriteLine();
                num2 = GetNumberFromUser();
            }
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            //Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
            return result;
        }
    }
}
