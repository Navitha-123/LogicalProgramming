using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class UC4ReverseNumber
    {
        public static void ReversingNumbers()
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());  
            for(int i=0;i<n;i++)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;

            }
            Console.WriteLine("Reversed number is:"+rev);
        }
      
    }
}
