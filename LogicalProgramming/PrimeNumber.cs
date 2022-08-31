using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public static void CalculatePrimeNumber()
        {
            int i, n, a = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());    
            for(i = 2; i <= n / 2 ; i++)
            {
                int res = n % i;
                if(res == 0)
                {
                    a++;
                    break; 
                }
            }
            if (a == 0 && n != 0)
            {
                Console.WriteLine(n + "Enter numbe is prime");
            }
            else
            {
                Console.WriteLine(n + "Enter number is not prime");
            }


        }
    }
}
