using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Ind1

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if ((a >= 0) & (b >= 0))
            {
                if (a > b)
                {
                    a = Math.Sqrt(b);
                    Console.WriteLine("Корень числа b = " + a);
                }
                else
                {
                    b = Math.Sqrt(a);
                    Console.WriteLine("Корень числа a = " + b);
                }

            }
            else
                Console.WriteLine("Error");
        }
    }
}
