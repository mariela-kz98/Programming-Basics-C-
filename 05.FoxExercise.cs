using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;

            //UpperPart 
            int starsUp = 1;
            int dashesUp = width - (2 * starsUp + 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",
                    new string('*', starsUp),
                    new string('-', dashesUp));
                starsUp++;
                dashesUp -= 2;

            }
            //Middle part
            int outerStars = n / 2;
            int middleStars = n;
            if (n >= 11)
            {

                for (int j = 0; j < n / 3; j++)
                {
                    Console.WriteLine(@"|{0}\{1}/{0}|",
                        new string('*', outerStars),
                        new string('*', middleStars));

                    outerStars++;
                    middleStars -= 2;
                }
            }
            else
            {
                for (int j = 0; j < n / 2 - 1; j++)
                {
                    Console.WriteLine(@"|{0}\{1}/{0}|",
                        new string('*', outerStars),
                        new string('*', middleStars));

                    outerStars++;
                    middleStars -= 2;
                }
            }
            // Lower part 
            int dashesLower = 1;
            int starsLower = width - (2 * dashesLower + 2);
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",
                    new string('-', dashesLower),
                    new string('*', starsLower));

                dashesLower++;
                starsLower -= 2;

            }
        }
    }
}
