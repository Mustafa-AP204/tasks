using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparison();
        }
         
        public static void Comparison()
        {
            Console.WriteLine("Enter Intermediate");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 50)
            {
                for (int i =1; i <= num; i++)
                {
                   if (i % 3 == 0)
                   {
                        Console.WriteLine(i);
                   }
                   
                }
            }
            else if (num > 50 && num < 100)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 5 == 0)
                    {
                         Console.WriteLine(i);
                    }
                }
                    
                
            }
            else if (num > 100)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }

    }
}
