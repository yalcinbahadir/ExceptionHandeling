using System;
using System.IO;
using System.Runtime.Serialization;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new FileNotFoundException("File XVZ not found.");
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no dublicate session allowed.");
            }
            catch (UserAlreadyLoggedInException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
           Console.ReadLine();
        }
    }

    //Creating custom exception
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException():base()
        {

        }
        public UserAlreadyLoggedInException(string message):base(message)
        {

        }
        // Allows you to track inner exceptions.
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }
        //Available in all applications
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
