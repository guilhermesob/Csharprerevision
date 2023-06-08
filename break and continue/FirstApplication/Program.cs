using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}