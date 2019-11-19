using System;
using System.Linq;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = sequence.Length / 4;

            var firsRowLeft = sequence
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRowRight = sequence
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firsRowLeft
                .Concat(firstRowRight)
                .ToArray();

            var secondRow = sequence
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sumFirstAndSecondRow = firstRow
                .Zip(secondRow, ((x, y) => x + y))
                .ToList();

            //sumFirstAndSecondRow = firstRow.
            //Select((x, index) => x +secondRow[index]);

            var result = string.Join(" ", sumFirstAndSecondRow);
            Console.WriteLine(result);
        }
    }
}
