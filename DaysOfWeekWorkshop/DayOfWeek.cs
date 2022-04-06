using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeekWorkshop
{
    internal class DayOfWeek
    {
        int y0, x, m0;
        public void DaysOfWeek(int m, int d, int y)
        {
            y0 = y - (14 - m)/ 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            int d1 = (d + x + (31 * m0)/ 12)%7;

            if (d1 == 0 || d1 == 7 || d1 == 14 || d1 == 21 || d1 == 28)
            {
                Console.WriteLine("Sunday");
            }
            else if (d1 == 1 || d1 == 8 || d1 == 15 || d1 == 22 || d1 == 29)
            {
                Console.WriteLine("Monday");
            }
            else if (d1 == 2 || d1 == 9 || d1 == 16 || d1 == 23 || d1 == 30)
            {
                Console.WriteLine("Tuesday");
            }
            else if (d1 == 3 || d1 == 10 || d1 == 16 || d1 == 24 || d1 == 31)
            {
                Console.WriteLine("Wednesday");
            }
            else if (d1 == 4 || d1 == 11 || d1 == 17 || d1 == 25)
            {
                Console.WriteLine("Thurday");
            }
            else if (d1 == 5 || d1 == 12 || d1 == 18 || d1 == 26)
            {
                Console.WriteLine("Friday");
            }
            else if (d1 == 6 || d1 == 13 || d1 == 19 || d1 == 27)
            {
                Console.WriteLine("Saturday");
            }
        }

    }
}
