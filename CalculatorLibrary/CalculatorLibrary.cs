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
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
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
            double result = double.NaN;
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result = double.NaN;
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Multiply(double num1, double num2)
        {
            double result = double.NaN;
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            double result = double.NaN;
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                Console.WriteLine();
                num2 = GetNumberFromUser();
            }
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
            return result;
        }
    }
}
