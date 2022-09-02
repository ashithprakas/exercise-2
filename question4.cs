using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("{0} is  a leap year", year);

                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year", year);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is  a leap year", year);
                }
            }

            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }

            Console.ReadKey();
        }
    }
}
