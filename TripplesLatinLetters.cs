using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TripplesLatinLetters
{
    class TripplesLatinLetters
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int pos1 = 0; pos1 < number; pos1++)
            {
                for (int pos2 = 0; pos2 < number; pos2++)
                {
                    for (int pos3 = 0; pos3 < number; pos3++)
                    {
                        char letterPosition1 = (char)('a' + pos1);
                        char letterPosition2 = (char)('a' + pos2);
                        char letterPosition3 = (char)('a' + pos3);
                        Console.WriteLine("{0}{1}{2}", letterPosition1, letterPosition2, letterPosition3);
                    }
                }
            }

        }
    }
}
