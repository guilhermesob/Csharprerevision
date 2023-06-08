using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 0;

            /*while (x < 7)
            {
                Console.WriteLine(x);
                x++;
            }*/

            /*do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 7);*/

            /* for (int x = 0; x <= 8; x = x + 2)
             {
                 Console.WriteLine(x);
             }*/

            // Loop over array items
            string[] fruits = { "Banana", "Fig", "Cherry", "Watermelon" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}