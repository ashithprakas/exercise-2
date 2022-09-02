using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question19
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int numbers = 1;


            for (int i = 1; i <= rows; i++)
            {

                for (int spaces = rows - i; spaces >= 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int content = 1; content < i + 1; content++)
                {
                    Console.Write(numbers + " ");
                    numbers++;
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }


    }
}


