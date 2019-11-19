using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        private static void ReverseNumber(string numberInput)
        {
            var numsToChar = numberInput.ToCharArray();
            Array.Reverse(numsToChar);
            Console.WriteLine(numsToChar);
        }
    }
}

