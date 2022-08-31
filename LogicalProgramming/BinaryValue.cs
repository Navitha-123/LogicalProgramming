using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class BinaryValue
    {
        public static void BinaryConversion()
        {
            string res;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
             res = "";
            while (num > 1)
            {
                int rem = num % 2;
                res = Convert.ToString(num) + res;
                num /= 2;
                

            }
            res = Convert.ToString(num) + res;
            Console.WriteLine("Binary " + res);


        }
    }
}
