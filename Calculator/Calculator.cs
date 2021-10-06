using System;


namespace CalculatorProgram

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Welcome To My Calculater!\r");
            Console.WriteLine("------------------------\n");

            Console.Write("press any other key and Enter to start, or Press 'n' and Enter to close the app : ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");

            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();

            while (!endApp)
            {
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                double cleanNum1;
                cleanNum1 = GetNumberFromUser();

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                double cleanNum2;
                cleanNum2 = GetNumberFromUser();
                
                //double[] n = new double[10];
                //for (int i = 0; i < 10; i++)
                //{
                 //   n[i] = GetNumberFromUser();
                //}

                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();


                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("To close the app Press 'n' and Enter, To Continue Press any other key and Enter: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
           
            return;
        }
        public static double GetNumberFromUser()
        {
            bool succeeded = false;
            double userInput = 0;
            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
    }
}

