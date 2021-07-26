using System;

namespace ExceptionHandelingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Denumerator");
                int denumerator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denumerator;
                Console.WriteLine($"Result is {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Only numbers between {Int32.MinValue} and {Int32.MaxValue} are allowed.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Denumerator can not be zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
