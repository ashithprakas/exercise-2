using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question10
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physics : ");
            int Physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Maths : ");
            int Maths = Convert.ToInt32(Console.ReadLine());

            int total = Physics + Chemistry + Maths;

            if ((Maths >= 65 && Physics >= 55 && Chemistry >= 50 && total >= 180) || total >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission ");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission ");
            }

            Console.ReadKey();


        }
    }
}
