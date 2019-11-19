using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyIncome
{
    class DailyIncome
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            decimal moneyPerDay = decimal.Parse(Console.ReadLine());
            decimal dollarRate = decimal.Parse(Console.ReadLine());

            decimal salaryPerMonth = workingDaysPerMonth * moneyPerDay;
            decimal bonusIncome = salaryPerMonth * 2.5m;
            decimal yearIncome = salaryPerMonth * 12 + bonusIncome;
            decimal taxes = yearIncome * 0.25m;
            decimal totalYearIncomeDollars = yearIncome - taxes;
            decimal totalYearIncomeLeva = totalYearIncomeDollars * dollarRate;
            decimal averageIncomePerDay = totalYearIncomeLeva / 365;

            Console.WriteLine("{0:f2}", averageIncomePerDay);
        }
    }
}
