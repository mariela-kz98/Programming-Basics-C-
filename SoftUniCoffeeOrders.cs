using System;
using System.Globalization;

namespace _03.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());

            decimal coffeePrice = 0;
            decimal totalOrderSum = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                DateTime dateOrder = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());

                int daysMonth = System.DateTime.DaysInMonth(dateOrder.Year, dateOrder.Month);
                coffeePrice = (daysMonth * capsuleCount) * capsulePrice;
                totalOrderSum += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
            }

            Console.WriteLine($"Total: ${totalOrderSum:F2}");
        }
    }
}
