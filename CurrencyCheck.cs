using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main()
        {
            decimal rubles = decimal.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal euro = decimal.Parse(Console.ReadLine());
            decimal levaSpecialOffer = decimal.Parse(Console.ReadLine());
            decimal leva = decimal.Parse(Console.ReadLine());

            decimal rublesToLeva = (rubles / 100) * 3.5m;
            decimal dollarsToLeva = dollars * 1.5m;
            decimal euroToLeva = euro * 1.95m;
            decimal specialLeva = levaSpecialOffer / 2;

            decimal minPrice = decimal.MaxValue;
            minPrice = Math.Min(rublesToLeva,minPrice);
            minPrice = Math.Min(dollarsToLeva,minPrice);
            minPrice = Math.Min(euroToLeva,minPrice);
            minPrice = Math.Min(specialLeva,minPrice);
            minPrice = Math.Min(leva,minPrice);

            Console.WriteLine("{0:f2}",minPrice);
        }
    }
}
