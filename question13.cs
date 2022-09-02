using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question13
    {
        static void Main(string[] args)
        {
            Console.Write("Input upto the table starting from 1 : ");
            int mul = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < mul + 1; j++)
                {
                    Console.Write("{0}X{1} = {2}", j, i, i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
