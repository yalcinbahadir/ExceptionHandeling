using System;
using System.IO;
using static System.Console;
namespace ExceptionVenkat
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\1myFolder\myFile.txt";
            StreamReader reader=null;
            try
            {
                reader = new StreamReader(path);
                var message = reader.ReadToEnd();
                WriteLine(message);
                //reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                WriteLine($"Please check if the file {ex.FileName} exists.");
                WriteLine(ex.Message);
                WriteLine();
                WriteLine();
                WriteLine(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                WriteLine($"Please check if the directory {ex} exists.");
                WriteLine(ex.Message);
                WriteLine();
                WriteLine();
                WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {

                WriteLine(ex.Message);
                WriteLine();
                WriteLine();
                WriteLine(ex.StackTrace);
            }
            finally
            {
                
                if (reader is not null)
                {
                    WriteLine("reader is not null.");
                    reader.Close();
                }
                WriteLine("Finally block.");
            }
     

            ReadLine();
        }
    }
}
