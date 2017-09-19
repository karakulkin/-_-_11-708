using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            if (h < 7)
                h = h * 30;
            else
                h = 360 - (h * 30);
            Console.WriteLine(h);
            Console.ReadKey();

        }
    }
}
