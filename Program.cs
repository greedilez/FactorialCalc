using System;

namespace FactorialFinder
{
    class Program
    {
        private static int targetValue = 1;

        private static int result = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter number: ");
                try
                {
                    targetValue = Convert.ToInt32(Console.ReadLine());
                    if(targetValue <= 10)
                    {
                        int valueIteration = targetValue;
                        for (int i = 0; i < targetValue; i++)
                        {
                            if (valueIteration > 1)
                            {
                                result *= valueIteration;
                                valueIteration--;
                            }
                            else
                            {
                                Console.WriteLine($"Result: {result}");
                                result = 1;
                                targetValue = 1;
                            }
                        }
                    }
                    else Console.WriteLine("Input number is too big.");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
