using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractByKeywordExercises
    {
        static void Main()
        {
            string keyWord = Console.ReadLine();

            string[] text = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pattern = "\\b" + keyWord + "\\b";
            Regex regex = new Regex(pattern);

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
