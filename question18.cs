using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question18
    {
        static void Main(string[] args)
        {
            int iterator = 1;
            for (int i = 0; i < 4; i++)
            {
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(iterator + " ");
                        iterator++;
                    }
                    Console.WriteLine();

                }
            }
            Console.ReadKey();
        }


    }
}
