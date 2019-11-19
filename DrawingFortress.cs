using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFortress
{
    class DrawingFortress
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fortWidth = 2 * n;
            //first Line;
            string upperPart = "/" + new string('^', n - 2) + "\\" + "/" + new string('^', n - 2) + "\\";
            string middlePart = "|" + new string(' ', n * 2 - 2) + "|";
            string lastLineMiddlePart = "|" + new string('_', n * 2 - 2) + "|";
            if (n <= 4)
            {
                Console.WriteLine(upperPart);
            }
            else
            {
                string upper = "/" + new string('^', n / 2) + "\\" + new string('_', n / 2) + "/" + new string('^', n / 2) + "\\";
                Console.WriteLine(upper);
            }
            // middle Part;
            for (int i = 0; i < n - 2; i++)
            {
                middlePart = "|" + new string(' ', n * 2 - 2) + "|";

                if (n == 6)
                {
                    middlePart = "|" + new string(' ', n * 2 -1) + "|";
                }
                else if (n == 7)
                {
                    middlePart = "|" + new string(' ', n * 2 - 3) + "|";
                }
                else if (n == 9)
                {
                    middlePart = "|" + new string(' ', n * 2 - 4) + "|";
                }
               
                   Console.WriteLine(middlePart); 
            }
            
            if (n < 5)
            {
                Console.WriteLine("\\" + new string('_', n / 2) + "/" + "\\" + new string('_', n / 2) + "/");
            }
            else
            {
                Console.WriteLine("|" + new string(' ', n / 2) + " " + new string('_', n / 2) + " " + new string(' ', n / 2) + "|");
                Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', n / 2) + "\\" + new string('_', n / 2) + "/");
            }
        }
    }

}
