using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
            }
            Console.ReadKey();
        }
    }
}
