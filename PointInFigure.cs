using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main()
        {
            int xOfPointToCheck = int.Parse(Console.ReadLine());
            int yOfPointToCheck = int.Parse(Console.ReadLine());

            int a1 = 2;
            int a2 = 1;

            int b1 = 12;
            int b2 = a2;

            int c1 = 2;
            int c2 = -3;

            int e1 = 4;
            int e2 = 3;

            int n1 = e1;
            int n2 = -5;

            int m1 = 10;
            int m2 = n2;

            bool xInsideTheHorizontalRectangle = xOfPointToCheck <= b1 && xOfPointToCheck >= a1;
            bool yInsideTheHorizontalRectangle = yOfPointToCheck <= a2 && yOfPointToCheck >= c2;

            bool xInsideVerticalRectangle = xOfPointToCheck <= m1 && xOfPointToCheck >= n1;
            bool yInsideVerticalRectangle = yOfPointToCheck >= n2 && yOfPointToCheck <= e2;

            if (xInsideTheHorizontalRectangle && yInsideTheHorizontalRectangle ||
                xInsideVerticalRectangle && yInsideVerticalRectangle)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
