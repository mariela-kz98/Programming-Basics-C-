using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '?', '!', ',', '.' };
            var text = Console.ReadLine()
                 .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            List<string> palindrome = new List<string>();
           // var reversed = string.Empty;
            foreach (var word in text)
            {
                var reversed = new string(word.ToArray().Reverse().ToArray());
                if (word == reversed)
                {
                    palindrome.Add(word);
                }
                palindrome.Sort();
            }
            var result = string.Join(", ", palindrome);
            Console.WriteLine(result);
            
        }
    }
}
