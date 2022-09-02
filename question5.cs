using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter candidate age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congratulations! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote");
            }

            Console.ReadKey();
        }
    }
}
