using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main()
        {
            //http:/pastebin.com/ecuXAYiq;

            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && ContainEvenDigit(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int num)
        {
            bool isPalindrome = true;
            string normal = num.ToString();
            for (int i = 0; i < normal.Length / 2; i++)
            {
                if (normal[i] != normal[normal.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainEvenDigit(int num)
        {
            bool containEvenDigit = false;
            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;
                if (lastDigit % 2 == 0)
                {
                    containEvenDigit = true;
                    break;
                }
            }
            if (containEvenDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
