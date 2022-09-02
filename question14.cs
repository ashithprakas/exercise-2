using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question14
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms : ");
            int terms = Convert.ToInt32(Console.ReadLine());

            int iterator = 0;
            int numbers = 1;
            int sum = 0;
            while (iterator < terms)
            {
                if (numbers % 2 != 0)
                {
                    Console.Write("{0} ", numbers);
                    sum += numbers;
                    iterator++;
                }
                numbers++;
            }
            Console.WriteLine("\nThe Sum of odd Natural Numbersupto 10 terms : " + sum);
            Console.ReadKey();
        }
    }
}
