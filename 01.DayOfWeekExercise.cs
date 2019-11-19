using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysInWeek = { "Monday", "Tuesday", "Wednesday",
                         "Thursday", "Friday", "Saturday", "Sunday"};
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(daysInWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
