using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.ParseDemon)
                .OrderBy(a => a.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Demon ParseDemon(string demonName)
        {
            var demon = new Demon();
            demon.Name = demonName;

            GetDemonHealth(demonName, demon);
            GetDemonDamage(demonName, demon);

            return demon;
        }

        static void GetDemonHealth(string demonName, Demon demon)
        {
            var listDemons = new List<int>();

            var healthPattern = @"[^0-9+\-*\/\.]";

            var health = Regex.Matches(demonName, healthPattern)
                .Cast<Match>()
                .Select(a => char.Parse(a.Value))
                .ToArray();

            foreach (var element in health)
            {
                listDemons.Add(element);
            }

            var demonHealth = listDemons.Sum();

            demon.Health = demonHealth;
        }

        static void GetDemonDamage(string demonName, Demon demon)
        {
            var damagePattern = @"(\+|-)?\d+(?:\.?\d+)?";

            var damage = Regex.Matches(demonName, damagePattern);
            var damageSum = 0m;
            foreach (Match match in damage)
            {
                damageSum += decimal.Parse(match.Value);
            }
            var modifiers = demonName
                .Where(a => a == '*' || a == '/')
                .ToArray();

            foreach (var sign in modifiers)
            {
                switch (sign)
                {
                    case '*':
                        damageSum *= 2;
                        break;
                    case '/':
                        damageSum /= 2;
                        break;
                }
            }
            demon.Damage = damageSum;
        }
    }
}
