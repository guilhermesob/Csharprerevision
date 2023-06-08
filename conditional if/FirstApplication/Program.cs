using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*if (50 > 20) 
            {
                 Console.WriteLine("This is true!");
            }*/

            int firstValue = 30;
            int secondValue = 30;

            if (firstValue < secondValue)
            {
                Console.WriteLine("second value is the biggest!");
            }
            else if (firstValue > secondValue)
            {
                Console.WriteLine("first value is the biggest!");
            }
            else
            {
                Console.WriteLine("first value equals second value");
            }

        }
    }
}