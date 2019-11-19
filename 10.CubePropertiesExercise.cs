using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main()
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            if (parameter == "face")
            {
                FaceDiagonal(sideOfCube);
            }
            else if (parameter == "space")
            {
                SpaceDiagonal(sideOfCube);
            }
            else if (parameter == "volume")
            {
                VolumeOfCube(sideOfCube);
            }
            else if (parameter == "area")
            {
                AreaOfCube(sideOfCube);
            }
        }
        static void FaceDiagonal(double side)
        {
            double faceDiagonals = Math.Sqrt(2 * side * side);
            Console.WriteLine("{0:f2}", faceDiagonals);
        }
        static void SpaceDiagonal(double side)
        {
            double spaceDiagonals = Math.Sqrt(3 * side * side);
            Console.WriteLine("{0:f2}", spaceDiagonals);
        }
        static void VolumeOfCube(double side)
        {
            double volumeOfCube = Math.Pow(side, 3);
            Console.WriteLine("{0:f2}", volumeOfCube);
        }
        static void AreaOfCube(double side)
        {
            double areaOfCube = 6 * side * side;
            Console.WriteLine("{0:f2}", areaOfCube);
        }
    }
}
