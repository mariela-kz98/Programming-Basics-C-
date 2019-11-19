using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool result = false;

            for (int i = 1; i <= n; i++)
            {
                int lastDigit = i % 10;
                int digit = i / 10;
                int sumDigits = lastDigit + digit;

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                Console.WriteLine("{0} -> {1}", i, result);
            }
        }
    }
}
