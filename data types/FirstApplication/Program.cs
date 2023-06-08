using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Data Types in C#
            string newMessage = "C# is popular!";  // string
            char newLetter = 'E'; // character
            int newNumber = 10; // integer
            long newNumber2 = 2000000000000L; // long
            double newDouble = 10.77D; // Floating point number
            bool newBoolean = false; // Boolean

            // Writing data on screen
            Console.WriteLine(newMessage);
            Console.WriteLine(newLetter);
            Console.WriteLine(newNumber);
            Console.WriteLine(newNumber2);
            Console.WriteLine(newDouble);
            Console.WriteLine(newBoolean);

            // Get Type
            Console.WriteLine(newMessage.GetType());
            Console.WriteLine(newLetter.GetType());
            Console.WriteLine(newNumber.GetType());
            Console.WriteLine(newNumber2.GetType());
            Console.WriteLine(newDouble.GetType());
            Console.WriteLine(newBoolean.GetType());
        }
    }
}