using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionLabyrinth
{
    class RecursionLabyrinthExercise
    {
        //Draw path directions and #define DEBUG_MODE ||>> show path and directions;
        static void Main()
        {
            FindExit(0, 0);
        }

        static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ',' '},
            {'*', '*', ' ', '*', ' ', '*',' '},
            {' ', ' ', ' ', ' ', ' ', ' ',' '},
            {' ', '*', '*', '*', '*', '*',' '},
            {' ', ' ', ' ', '*', ' ', ' ','e'},
        };

        //static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        //static int position = 0;

        static void FindExit(int row, int col)
        {
            // path[position++] = direction;

            if ((col < 0) || (row < 0) ||
                (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // out of the labyrinth >> can't find a path
                return;
            }
            //Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                Console.WriteLine("Found the exit!");

            }
            if (lab[row, col] != ' ')
            {
                //The current cell is not free >> can't find a path
                return;
            }
            //Temporary mark the current cell as visited
            lab[row, col] = 'S';
            //Invoke recursion to explore all possibledirections
            FindExit(row, col - 1); //LEFT
            FindExit(row - 1, col); //up
            FindExit(row, col + 1); //right
            FindExit(row + 1, col); //down

            //Mark back the current cell as free
            lab[row, col] = ' ';
            //position--;
        }

    }
}
