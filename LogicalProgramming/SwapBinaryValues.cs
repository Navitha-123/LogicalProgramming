using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SwapBinaryValues
    {
      public static int BinarySwap(int x)
        {
            Console.WriteLine("Enter value ");
            int val = Convert.ToInt32(Console.ReadLine);
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
            Console.WriteLine("x value is " +x);
        }
    }
}
