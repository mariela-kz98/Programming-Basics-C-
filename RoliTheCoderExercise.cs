using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RoliTheCoder
{
    class RoliTheCoderExercise
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                var line = input
                    .Split(new char[] { '@', '#' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(i => i.Trim())
                    .ToArray();

                var id = line[0];
                var eventName = line[1];
                var participants = line.Skip(2).Take(line.Length - 1);

                if (id.Contains(eventName))
                {
                    //add
                    if (!result.ContainsKey(eventName))
                    {
                        result[eventName] = new List<string>();
                    }
                    foreach (var participant in participants)
                    {
                        if (!result[eventName].Contains(participant))
                        {
                            result[eventName].Add(participant);
                        }

                    }
                }
                input = Console.ReadLine();
            }

            var events = result
                .OrderByDescending(e => e.Value.Count)
                .ThenBy(e => e);
            foreach (var currentEvent in events)
            {
                var eventName = currentEvent.Key;
                var participants = currentEvent.Value;

                Console.WriteLine($"{eventName} - {participants.Count}");
                foreach (var person in participants.OrderBy(p => p))
                {
                    Console.WriteLine($"{person}");
                }
            }

        }
    }
}
