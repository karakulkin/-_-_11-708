using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
	// ---check--- можно было это сделать без цикла
        static void Main(string[] args)
        {
            int kol = 1;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double sum = a;
            while (a!=b)
            {
                kol++;
                sum = sum + (a + c);
                a = a + c;
            }
            Console.WriteLine(kol);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
