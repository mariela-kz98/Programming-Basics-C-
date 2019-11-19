using System;
using System.Linq;

namespace _14.LadybugsSolved
{
    class LadybugsSolvedExercise
    {
        static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            var bugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a > 0 && a < sizeField)
                .ToArray();

            var ladybugs = new int[sizeField];

            for (int i = 0; i < bugIndexes.Length; i++)
            {
                var index = bugIndexes[i];
                ladybugs[index] = 1;
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var parts = line.Split();

                var bugIndex = int.Parse(parts[0]);
                var direction = parts[1];
                var flyLenght = int.Parse(parts[2]);

                if (bugIndex < 0 || bugIndex >= ladybugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladybugs[bugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                FlyLadybug(ladybugs, bugIndex, flyLenght, direction);

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        static void FlyLadybug(int[] ladybugs, int bugIndex, int flyLenght, string direction)
        {
            ladybugs[bugIndex] = 0;

            var findingPlace = false;
            while (!findingPlace)
            {
                switch (direction)
                {
                    case "left":
                        bugIndex -= flyLenght;
                        break;
                    case "right":
                        bugIndex += flyLenght;
                        break;
                }

                if (bugIndex < 0 || bugIndex >= ladybugs.Length) // outside the array
                {
                    findingPlace = true;
                    continue;
                }
                if (ladybugs[bugIndex] == 1) // on another ladybig position
                {
                    continue;
                }
                if (ladybugs[bugIndex] == 0) //find place
                {
                    ladybugs[bugIndex] = 1;
                    findingPlace = true;
                    continue;
                }
            }
        }
    }
}
