using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Squareroot
    {
        public static void RootOfSquare()
        {
            Console.WriteLine("Enter the number");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            float epsilon = 0.0001f; 
            if(Math.Abs(t - c / t) > epsilon * t)
            {
                Console.WriteLine(Math.Sqrt(c));
            }
        }
    }
}
