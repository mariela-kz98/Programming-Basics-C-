using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElementsExercise
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            GetMaxSequenceOfEqualElements(sequence);
        }

        private static void GetMaxSequenceOfEqualElements(List<int> sequence)
        {
            int maxStart = 0;
            int maxLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == sequence[currentStart])
                {
                    currentLength++;
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }
            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }
        }
    }
}
