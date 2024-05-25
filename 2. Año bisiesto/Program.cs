using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Año_bisiesto
{
    internal class Program
    {
        static bool IsLeapYear (int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a year");
                int year = int.Parse(Console.ReadLine());

                bool leapYear = IsLeapYear(year);

                Console.WriteLine(leapYear ? "Leap year" : "Not a leap year");

                Console.WriteLine("Would you like to enter another year? --- yes/no");
                string response = Console.ReadLine().ToLower();
                Console.WriteLine("------------------------------------------------");

                if (response != "yes")
                {
                    break;
                }
            } while (true);
        }
    }
}
