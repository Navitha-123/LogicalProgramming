﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class MonthlyPayment
    {
        public static void CalculatePaymentMonth()
        {
            Console.WriteLine("Enter principal");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Year");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            double r = Convert.ToDouble(Console.ReadLine());
            double n = 12 * y;
            double r1 = r / (12 * 100);
                double payment = p * r1 / 1 - Math.Pow((1 + r), (-n));
            Console.WriteLine("payment :"+payment);


        }
    }
}
