using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(number);
            BigInteger zeroesCount = FactorialTrailingZeroes(factorial);
            Console.WriteLine(zeroesCount);
        }
        static BigInteger Factorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int FactorialTrailingZeroes(BigInteger factorial)
        {
            int count = 0;
            while (factorial % 10 == 0)
            {
                count++;
                factorial /= 10;
            }
            return count;
        }
    }
}
