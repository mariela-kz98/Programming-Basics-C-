using System;
using System.Collections.Generic;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<string, string> phonebookSorted =
                new SortedDictionary<string, string>();

            while (!input.Equals("END"))
            {
                string[] inputCommands = input.Split(' ');
                input = Console.ReadLine();

                if (inputCommands[0].Equals("A"))
                {
                    string name = inputCommands[1];
                    string number = inputCommands[2];

                    phonebookSorted[name] = number;
                }
                else if (inputCommands[0].Equals("ListAll"))
                {
                    foreach (var contact in phonebookSorted)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                else if (inputCommands[0].Equals("S"))
                {
                    string name = inputCommands[1];

                    if (phonebookSorted.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebookSorted[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}

