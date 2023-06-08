using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newObj = new Player();
            Player newObj2 = new Player();
            Player newObj3 = new Player();

            Console.WriteLine(newObj.name);
            Console.WriteLine(newObj.number);
            Console.WriteLine(newObj2.name);
            Console.WriteLine(newObj2.number);
            Console.WriteLine(newObj3.name);
            Console.WriteLine(newObj3.number);

        }
    }
}
