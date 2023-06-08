using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer to Double
            /*           int newNum = 11;
                       double newNum2 = newNum;

                       Console.WriteLine(newNum.GetType());
                       Console.WriteLine(newNum2.GetType());*/

            // Double to integer
            /*       double newNum3 = 11.32;
                   int newNum4 = (int)newNum3;

                   Console.WriteLine(newNum3.GetType());
                   Console.WriteLine(newNum4.GetType());*/

            // Converting types using methods
            int newInt = 20;
            double newDouble = 11.25;
            bool newBool = false;

            Console.WriteLine(Convert.ToString(newInt));
            Console.WriteLine(Convert.ToDouble(newInt));
            Console.WriteLine(Convert.ToInt32(newDouble));
            Console.WriteLine(Convert.ToString(newBool));
        }
    }
}