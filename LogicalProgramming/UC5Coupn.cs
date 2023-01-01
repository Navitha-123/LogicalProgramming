using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class UC5Coupn
    {
        public static void Coupnnumber()
        {
            int distinct = 0, count = 0;
            Console.WriteLine("Enter number of distinct coupns");
            int coupnnum = Convert.ToInt32(Console.ReadLine());
            bool[] iscollect = new bool[coupnnum];
            while (distinct < coupnnum)
            {
                Random random = new Random();   
                int newcoupn = (int)random.Next(coupnnum);
                count++;
                if (!iscollect[newcoupn])
                {
                    distinct++;
                    iscollect[newcoupn] = true;
                }
            }
            Console.WriteLine("total random number needed to have all distonct coupns :" +count);
        }
    }
}
