using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question11
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms ; ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int cube;
            for (int i = 1; i < terms + 1; i++)
            {
                cube = i * i * i;
                Console.WriteLine("Number is : {0} and cube of {0} is : {1}", i, cube);
            }
            Console.ReadKey();
        }
    }
}
