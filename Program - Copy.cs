using System;

namespace task2coded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator();
        }
        #region
        public static void Operator()
        {
            Console.WriteLine("Enter the num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an option");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Subtract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Divide");
            int result = 0;
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Please, enter the number!");
                    break;
            }
            Console.WriteLine();


        }
    }
}
#endregion