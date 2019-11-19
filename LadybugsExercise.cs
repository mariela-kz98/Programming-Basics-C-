using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ladybugs
{
    class LadybugsExercise
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            List<int> indexLadybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();

            var field = new int[sizeField];
            int index = 0;
            int length = 0;

            while (command[0] != "end")
            {
                for (int i = 0; i < indexLadybugs.Count; i++)
                {
                    index = indexLadybugs[i];
                    if (index > 0 && index < sizeField - 1)
                    {
                        field[index] = 1;
                    }
                }
                switch (command[1])
                {
                    case "right":
                        index = int.Parse(command[0]);
                        length = int.Parse(command[2]);
                        if (length < 0)
                        {
                            //method for right case
                        }
                        for (int i = 0; i < field.Length; i++)
                        {
                            if (field[i] == field[index])  // i == index
                            {
                                //length += length; // ++ length if in cell has ladybug
                                field[i + length] = 1; // out of range
                            }
                            else if (field[i] == 0)
                            {
                                field[i] = 1;
                            }
                        }
                        break;

                    case "left":

                        break;
                }
                
                command = Console.ReadLine().Split(' ');
            }
            var output = string.Join(" ", field);
            Console.WriteLine(output);
        }
    }
}
