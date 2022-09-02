using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question6
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter value of m : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;

            n = m > 0 ? 1 : m == 0 ? 0 : -1;

            Console.WriteLine("The value of n is {0} ", n);
            Console.ReadKey();
        }

    }
}
