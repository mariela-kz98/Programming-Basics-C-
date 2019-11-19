using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main()
        {


            //Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
            // List<string> listCountries = new List<string>();

            var countriesTotal = new Dictionary<string, Dictionary<string, long>>();

            int totalPopCountry = 0;

            var input = Console.ReadLine();
            while (input != "report")
            {
                var line = input.Split('|');
                var city = line[0];
                string country = line[1];   // <<==
                long population = long.Parse(line[2]);

                if (!countriesTotal.ContainsKey(country))
                {
                    countriesTotal.Add(country, new Dictionary<string, long>());
                }

                if (!countriesTotal[country].ContainsKey(city))
                {
                    countriesTotal[country][city] = population;
                    // countriesTotal[country].Add(city, populationOfCity);
                }

               



                input = Console.ReadLine();
            }
            Console.WriteLine("test");

        }
    }
}


//Dictionary<string, int> cityPopulation = new Dictionary<string, int>();

//cityPopulation["Kanzas"] = 200;
//cityPopulation["Stz"] = 5555;
//cityPopulation["Vraca"] = 33;
//cityPopulation["Sofia"] = 100000;

//var result = cityPopulation.OrderByDescending(x => x.Value);

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Key} > {item.Value}");
//}
