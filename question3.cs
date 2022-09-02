using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            if (num1 >= 0)
            {
                Console.WriteLine("{0} is a positive integer", num1);
            }

            else
            {
                Console.WriteLine("{0} is a negative integer", num1);
            }
            Console.ReadKey();

        }
    }
}
