using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class DreamItem
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            int hoursPerDay = int.Parse(input[2]);
            decimal priceForItem = decimal.Parse(input[3]);

            const int holidays = 10;
           
            int workingDaysPerMonth = 0;
            decimal salaryPerMonth = 0;
            decimal bonus = 0;

            if (month == "Feb" )
            {
                workingDaysPerMonth = 28 - holidays;
            }
            else if (month == "Jan" || month == "March" 
                    || month == "May" || month == "July" 
                    || month == "Aug" || month == "Oct" 
                    || month == "Dec")
            {
                workingDaysPerMonth = 31 - holidays;
            }
            else if(month == "Apr" || month == "June" 
                 || month == "Sept" || month == "Nov")
            {
                workingDaysPerMonth = 30 - holidays;
            }
            salaryPerMonth = workingDaysPerMonth * (moneyPerHour * hoursPerDay);
           
            if (salaryPerMonth > 700)
            {
                bonus = salaryPerMonth * 0.1m;
            }
            if (salaryPerMonth > priceForItem)
            {
                decimal moneyLeft = (salaryPerMonth + bonus) - priceForItem;
                Console.WriteLine("Money left = {0:f2} leva.",moneyLeft);
            }
            else
            {
                decimal moneyNeeded = priceForItem - (salaryPerMonth + bonus);
                Console.WriteLine("Not enough money. {0:f2} leva needed.",moneyNeeded);
            }
            //0.00 error
        }
    }
}
