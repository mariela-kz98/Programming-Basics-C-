using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayManipulator
{
    class ArrayManipulatorExercise
    {
        static void Main()
        {
            //test Each Method
            List<int> numbersSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //int index = 0;
            //int element = 0;
            //List<int> rangeElements = new List<int>();
            //int times = 0;

            while (input[0] != "print")
            { 
                //input.Select(int.Parse);

                switch (input[0])
                {
                    case "add":
                        AddElementAtIndex(numbersSequence, input);
                        break;

                    case "addMany":
                        AddRangeOfElementsAtIndex(input, numbersSequence);
                        break;

                    case "contains":
                        element = input[1];
                        CheckContainElement(numbersSequence, element);
                        break;

                    case "remove":
                        index = input[1];
                        RemoveAtIndex(numbersSequence, index);
                        break;

                    case "shift":
                        times = input[1];
                        RotateNTimes(numbersSequence, times);
                        break;

                    case "sumPairs":
                        GetSumOfPairs(numbersSequence);
                        break;

                    case "print":
                        PrintStateOfArray(numbersSequence);
                        break;
                }
            }

        }
        //correct
        static List<int> AddElementAtIndex(List<int> nums,string[] input )
        {
            int index = int.Parse(input[1]);
            int element = int.Parse(input[2]);
            nums[index] = element;
            return nums;
        }

         // error
        static List<int> AddRangeOfElementsAtIndex(string[] input, List<int> numbersSequence)
        {
            var index = input[1];
            var listNums = new List<int>();

            for (int i = 1; i < input.Length; i++)
            {
               // listNums[i - 1] = input[i + 1];
            }

            return numbersSequence;
        }

        static void CheckContainElement(List<int> nums, int[] input)
        {
            int element = input[1];
            int index = 0;
            if (nums.Contains(element))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (element == nums[i])
                    {
                        index = nums[i];
                    }
                    else
                    {
                        index = -1;
                    }
                }
            }
            Console.WriteLine(index);
        }

        static List<int> RemoveAtIndex(List<int> nums, int index)
        {
            nums.RemoveAt(index);

            return nums;
        }

        static List<int> RotateNTimes(List<int> nums, int rotations)
        {
            int length = nums.Count;

            for (int position = 0; position < rotations; position++)
            {
                int lastElement = nums[length - 1];

                for (int element = length - 1; element > 0; element--)
                {
                    nums[element] = nums[element - 1];
                }
            }
            return nums;
        }

        static List<int> GetSumOfPairs(List<int> nums)
        {
            int sum = 0;

            List<int> sumPairs = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    sum = nums[i] + nums[j];
                    sumPairs[i] = sum;
                }
            }
            sumPairs = nums;

            return nums;
        }

        static void PrintStateOfArray(List<int> numbersSequence)
        {
            Console.WriteLine($"[ {string.Join(" ", numbersSequence)} ]");
        }

    }
}
