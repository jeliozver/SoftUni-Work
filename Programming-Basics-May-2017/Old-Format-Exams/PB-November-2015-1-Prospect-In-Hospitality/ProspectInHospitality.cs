using System;

namespace PB_November_2015_1_Prospect_In_Hospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            decimal builders = decimal.Parse(Console.ReadLine());
            decimal receptionists = decimal.Parse(Console.ReadLine());
            decimal chambermaids = decimal.Parse(Console.ReadLine());
            decimal technicians = decimal.Parse(Console.ReadLine());
            decimal otherStaff = decimal.Parse(Console.ReadLine());
            decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal rateUSD = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal totalStaffSalary = builders * 1500.04m + receptionists * 2102.10m + 
                                       chambermaids * 1465.46m + technicians * 2053.33m +
                                       otherStaff * 3010.98m;
            decimal nikiSalary = nikiSalaryUSD * rateUSD;
            decimal totalSalary = totalStaffSalary + nikiSalary + mySalary;

            Console.WriteLine($"The amount is: {totalSalary:f2} lv.");
            if (budget >= totalSalary)
            {
                decimal moneyLeft = budget - totalSalary;
                Console.WriteLine($"YES \\ Left: {moneyLeft:f2} lv.");
            }
            else
            {
                decimal moneyNeeded = totalSalary - budget;
                Console.WriteLine($"NO \\ Need more: {moneyNeeded:f2} lv.");
            }
        }
    }
}