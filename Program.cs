using System;
using System.Reflection.Metadata.Ecma335;

namespace MyFirstProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("---------------------------------");
                Console.WriteLine("C# Calculator App for Beginners!");
                Console.WriteLine("---------------------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please pick: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} is equal to: {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} is equal to: {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} is equal to: {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} is equal to: {result}");
                        break;
                    default:
                        Console.WriteLine("You haven't picked a valid option. Please try again!");
                        break;

                }

                Console.WriteLine("Would you like to continue?: (Y = yes), (N = no)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
        }
    }
}