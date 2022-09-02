using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question16
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(j + 1);
                    }
                    Console.WriteLine();

                }
            }
            Console.ReadKey();
        }

    }
}
