using System;

namespace ExceptionHandelingSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int numerator;
                int denumerator=-1; 
                if (int.TryParse(Console.ReadLine(), out numerator))
                {
                    Console.WriteLine("Please enter Denumerator");

                    if (int.TryParse(Console.ReadLine(), out denumerator))
                    {
                        if (denumerator != 0)
                        {
                            int result = numerator / denumerator;
                            Console.WriteLine($"Result is {result}");
                        }
                        else
                        {
                            Console.WriteLine($"Denumerator can not be zero.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Denumerator should be a valid number between {Int32.MinValue} and {Int32.MaxValue}.");
                    }
                }
                else
                {
                    Console.WriteLine($"Numerator should be a valid number between {Int32.MinValue} and {Int32.MaxValue}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
