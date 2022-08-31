using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public static void NumberPerfect()
        {
            int num, res = 0, n;
            Console.Write(" enter the number ");
            num = int.Parse(Console.ReadLine());
            n = num;
            for (int a = 1; a < num; a++)
            {
                if (num % a == 0)
                {
                    res = res + a;
                }
            }
            if (res == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
            }
        }
        
    }
}
