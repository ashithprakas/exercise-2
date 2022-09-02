using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question7
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter height : ");
            int height = Convert.ToInt32(Console.ReadLine());


            string category = height < 145 ? "a dwarf" : height > 213 ? "a giant" : "of average height";

            Console.WriteLine("The person is {0}  ", category);
            Console.ReadKey();
        }
    }
}
