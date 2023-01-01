using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class UC1Fibonacci
    {
        public static void FibonacciNumbers(int len)
        {
            int num1 = 0, num2 = 1, num3 = 0;
            Console.WriteLine("{0} {1} " , num1, num2);
            for(int i = 0; i < 10 ; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine("{0}",num3);
                num1 = num2;
                num2 = num3;
            }
            
        }
    }
}
