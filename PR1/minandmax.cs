using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int max = x;
            int min = x;
	    // ---check--- while(x!=0)
            while ((x > 0)||(x<0))
            {
                 x = Convert.ToInt32(Console.ReadLine());
                if ((x < min)&(x!=0))
                {
                    min = x;
                }
                else if ((x > max) &(x != 0))
                {
                    max = x;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
