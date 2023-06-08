using System;

namespace FirstApplication
{
    class PlayerProgram
    {
        static void Main(string[] args)
        {
            PL01 newPlayer = new PL01();

            newPlayer.Speaking();  // Calling Speaking method to display the speaking on screen

            // Output value of name and ID
            Console.WriteLine($"{newPlayer.name} and {newPlayer.playerID}");
        }
    }
}