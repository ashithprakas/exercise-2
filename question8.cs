using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question8
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            string largest = num1 > num2 ? num1 > num3 ? "first" : "third" : num2 > num3 ? "second" : "third";

            Console.WriteLine("The {0} number is the largest among three", largest);
            Console.ReadKey();
        }
    }
}
