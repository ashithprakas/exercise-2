using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class question9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the coordinate x value : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the coordinate y value : ");
            int y = Convert.ToInt32(Console.ReadLine());

            string quadrant;

            if (x > 0 && y > 0)
            {
                quadrant = "First";
            }
            else if (x < 0 && y < 0)
            {
                quadrant = "Third";
            }
            else if (x < 0 && y > 0)
            {
                quadrant = "Second";
            }
            else
            {
                quadrant = "Fourth";
            }

            Console.WriteLine("The coordinate point ({0},{1}) lies in the {2} quadrant", x, y, quadrant);
            Console.ReadKey();

        }
    }
}
