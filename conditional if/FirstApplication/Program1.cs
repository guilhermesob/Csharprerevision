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

            /*int firstValue = 30;
            int secondValue = 25;

            if (firstValue == secondValue)
            {
                Console.WriteLine("The first collection here!");
            }
            else if (secondValue > firstValue)
            {
                Console.WriteLine("The second collection here!");
            }
            else
            {
                Console.WriteLine("Another collection!!");
            }*/

            // type variableName = (Test) ? True: False;
            int counting = 30;
            string newResult = (counting > 25) ? "First one" : "Second one";
            Console.WriteLine(newResult);
        }
    }
}
