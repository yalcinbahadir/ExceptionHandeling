using System;
using System.IO;
using static System.Console;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    WriteLine("Enter the first number.");
                    int FN = int.Parse(ReadLine());
                    //int.MaxValue
                    WriteLine("Enter the second number.");
                    int SN = int.Parse(ReadLine());
                    int result = FN / SN;
                    WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    path += @"\LogFiles\Log1.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter writer = new StreamWriter(path, true);
                        writer.WriteLine(ex.GetType().FullName);
                        writer.Close();
                        WriteLine("There is an error, please try later.");
                    }
                    else
                    {
                        throw new FileNotFoundException(path + " is not found.", ex); //ex represents the inner exception.
                                                                                      //inner exception: is the exception that caused the current exception.
                    }

                }

            }
            catch (Exception exception)
            {
                WriteLine("Current exception: "+exception.GetType().Name);
                if (exception.InnerException is not null)
                {
                    WriteLine("Inner exception: " + exception.InnerException.GetType().Name);
                }
               

            }
            ReadLine();
        }
    }
}
