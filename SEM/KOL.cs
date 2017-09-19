using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)//задачи на семинар expr 4
        {
            int k = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                if (i % x == 0)
                    k=k+1;
                else
                    if (i % y == 0)
                    k=k+1;

            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
