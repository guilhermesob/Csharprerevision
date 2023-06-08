using System;


namespace NewApp
{
    class Program
    { 
 
        static void Main(string[] args)
        {
            // Declare and define Array
            /*int[] degrees = { 20, 30, 31, 32, 40 };
            string[] fruits = { "Apple", "Banana", "Fig", "Cherry" };

            // How many elements?!
            Console.WriteLine(fruits.Length);
            Console.WriteLine(degrees.Length);*/

            // Accessing values
            /*Console.WriteLine(fruits[0]); // Apple
            Console.WriteLine(fruits[1]); // Banana
            Console.WriteLine(fruits[2]); // Fig*/

            // Changing values
            /*fruits[0] = "Watermelon";
            fruits[1] = "Lemon";
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);*/
            
            int[] degrees = { 200, 30, 31, 32, 40 };
            string[] fruits = { "Apple", "Banana", "Fig", "Cherry" };
            // Loop through fruits
            /*for (int fruit = 0; fruit < fruits.Length; fruit++)
            {
                Console.WriteLine(fruits[fruit]);
            }*/
           /* Array.Sort(fruits);
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }*/

            Array.Sort(degrees);
            foreach (int degree in degrees)
            {
                Console.WriteLine(degree);
            }
        }
    }
}
