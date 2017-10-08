using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {int n = 0;
            Console.Write("введите число--");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите систему счисления--");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите число--");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите систему счисления--");
            double m = Convert.ToDouble(Console.ReadLine());
            double a10 = 0,b10=0;
            while (a != 0)
            { a10 = a10 + (a%10 * (Math.Pow(k,n)));
                a = a / 10;
                n++;
            }
            n = 0;
            while (b != 0)
            {
                b10 = b10 + (b % 10 * (Math.Pow(m, n)));
                b = b / 10;
                n++;
            }
            Console.WriteLine(a10);
            Console.WriteLine(b10);
            Console.ReadKey();
        }
    }
}
