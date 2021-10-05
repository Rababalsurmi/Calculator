//using System;

//namespace Calculator

//{
//    public class Calculator
//    {
//        public static double DoOperation(double num1, double num2, string op)
//        {
//            double result = double.NaN;

//            switch (op)
//            {
//                case "a":
//                    result = Add(num1, num2);
//                    break;
//                case "s":
//                    result = Subtract(num1, num2);
//                    break;
//                case "m":
//                    result = Multiply(num1, num2);
//                    break;
//                case "d":
//                    result = Divide(num1, num2);
//                    break;
//                default:
//                    Console.WriteLine("Invalid input, try again.");
//                    break;
//            }
//            return result;
//        }
//        public static double GetNumberFromUser()
//        {
//            double userInput = 0;
//            bool succeeded = false;

//            while (!succeeded)
//            {
//                succeeded = double.TryParse(Console.ReadLine(), out userInput);

//            }
//            return userInput;
//        }

//        public static double Add(double num1, double num2)
//        {
//            double result = double.NaN;
//            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
//            return result;
//        }

//        public static double Subtract(double num1, double num2)
//        {
//            double result = double.NaN;
//            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//            return result;
//        }

//        public static double Multiply(double num1, double num2)
//        {
//            double result = double.NaN;
//            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
//            return result;
//        }

//        public static double Divide(double num1, double num2)
//        {
//            double result = double.NaN;
//            while (num2 == 0)
//            {
//                Console.WriteLine("Enter a non-zero divisor: ");
//                Console.WriteLine();
//                num2 = GetNumberFromUser();
//            }
//            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
//            return result;
//        }
//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            bool endApp = false;

//            Console.WriteLine("Welcome To My Calculater!\r");
//            Console.WriteLine("------------------------\n");

//            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to start: ");
//            if (Console.ReadLine() == "n") endApp = true;

//            Console.WriteLine("\n");

//            while (!endApp)
//            {
//                double result;

//                // Ask the user to type the first number.
//                Console.Write("Type a number, and then press Enter: ");
//                double cleanNum1;
//                cleanNum1 = GetNumberFromUser();

//                // Ask the user to type the second number.
//                Console.Write("Type another number, and then press Enter: ");
//                double cleanNum2;
//                cleanNum2 = GetNumberFromUser();

//                Console.WriteLine("Choose an operator from the following list:");
//                Console.WriteLine("\ta - Add");
//                Console.WriteLine("\ts - Subtract");
//                Console.WriteLine("\tm - Multiply");
//                Console.WriteLine("\td - Divide");
//                Console.Write("Your option? ");

//                string op = Console.ReadLine();

//                try
//                {
//                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
//                    if (double.IsNaN(result))
//                    {
//                        Console.WriteLine("This operation will result in a mathematical error.\n");
//                    }
//                    else Console.WriteLine("Your result: {0:0.##}\n", result);

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
//                }

//                Console.WriteLine("------------------------\n");

//                // Wait for the user to respond before closing.
//                Console.Write("To close the app Press 'n' and Enter, To Continue Press any other key and Enter: ");
//                if (Console.ReadLine() == "n") endApp = true;

//                Console.WriteLine("\n");
//            }
//            Console.Clear();
//            return;
//        }
//        public static double GetNumberFromUser()
//        {
//            bool succeeded = false;
//            double userInput = 0;
//            while (!succeeded)
//            {
//                succeeded = double.TryParse(Console.ReadLine(), out userInput);
//            }
//            return userInput;
//        }
//    }
//}
    
