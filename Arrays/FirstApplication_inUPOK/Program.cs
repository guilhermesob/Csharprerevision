using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of fruits
            string[] fruits = { "Apple", "Banana", "Cherry", "Fig", "Lemon" };
            int[] degrees = { 20, 21, 22, 23, 24, 25, 26, 27 };

            // Accessing items
            /*Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);*/

            // Changing values
            fruits[0] = "Watermelon";
            // Console.WriteLine(fruits[0]);

            // Get array length
            //Console.WriteLine(degrees.Length);

            // loop through fruits
            /*for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/

            /*foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/
            // Sorting fruits
            Array.Sort(fruits);
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}