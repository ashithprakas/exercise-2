using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question12
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number (Table to be calculated) : ");
            int mul = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", mul, i, mul * i);
            }

            Console.ReadKey();
        }
    }
}
