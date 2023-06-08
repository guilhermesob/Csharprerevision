using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class MyProgram
    {
        enum MonthsOfYear
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            //MonthsOfYear myMonth = MonthsOfYear.March;
            int myMonthNumber = (int) MonthsOfYear.January;
            Console.WriteLine(myMonthNumber);
        }
    }
}
