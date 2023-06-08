using System;

namespace NewApp
{
    class Program
    {
        /*static void NewGreeting(string name, int number)
        {
            Console.WriteLine($"Hello and welcome {name}, your number is {number}");
        }*/

        static int NewAddition(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int result = NewAddition(10, 20);
            Console.WriteLine(result);
            /*Console.WriteLine(NewAddition(20, 30));
            Console.WriteLine(NewAddition(25, 35));
            Console.WriteLine(NewAddition(40, 50));*/
            /*NewGreeting("Ahmed", 8);
            NewGreeting("Salah", 11);
            NewGreeting("Ronaldo", 7);
            NewGreeting("Messi", 30);*/
        }
    }
}