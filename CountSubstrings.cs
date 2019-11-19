using System;

class CountSubstringsExercise
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine().ToLower();
        var searchText = Console.ReadLine().ToLower();

        int index = 0;
        int count = 0;
        while (true)
        {
            var found2 = text.IndexOf(searchText, index);
            if (found >= 0)
            {
                count++;
                index = found + 1;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}
