using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            try
            {
                int[] newDegrees = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine(newDegrees[11]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("All the operations finished!");
            }
        }
    }
}
