using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syndicate.Breakthrough.Domain;
using Syndicate.Breakthrough.Domain.Model;

namespace Syndicate.Breakthrough.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var facility = new Facility(Guid.NewGuid(), new Money(10000000));
            facility.Loan = new Loan(facility, new Money(400000));
            facility.Investments.Add(new Investment(Guid.NewGuid(), new Company(Guid.NewGuid(), "HSBC"),  15));
            facility.Investments.Add(new Investment(Guid.NewGuid(), new Company(Guid.NewGuid(), "ALPHA BANK"),  85));

            Console.WriteLine("A P P");
            Console.WriteLine("");

            while (true)
            {
                DisplayMenu();
                var key = Console.ReadKey().Key;
                Console.WriteLine("");
                
                if (key == ConsoleKey.Q)
                {
                    break;
                }

                if (key == ConsoleKey.D1)
                {
                    DisplayFacilityInfo(facility);
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.Write("Enter an amount to increase loan: ");
                    var amn = Convert.ToDecimal(Console.ReadLine());
                    facility.Loan.Increase(new Money(amn));
                    DisplayFacilityInfo(facility);
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.Write("Enter an amount to decrease loan: ");
                    var amn = Convert.ToDecimal(Console.ReadLine());
                    facility.Loan.Decrease(new Money(amn));
                    DisplayFacilityInfo(facility);
                }


                Console.WriteLine("");
            }


            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("M E N U");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press [1] to display facility info.");
            Console.WriteLine("Press [2] to increase falicity loan.");
            Console.WriteLine("Press [3] to decrease falicity loan.");
            Console.WriteLine("Press [Q] to exit.");
        }

        private static void DisplayFacilityInfo(Facility facility)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("F A C I L I T Y");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Id: {0}", facility.Id);
            Console.WriteLine("Limit: {0}", facility.Limit);
            Console.WriteLine("Loan: {0}", facility.Loan.Amount);
            Console.WriteLine("Investments: {0}", 
                facility.Investments.Select(i => i.ToString()).Aggregate((current, next) => current + ", " + next));
        }
    }
}
