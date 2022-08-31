using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class TemperatureConversion
    {
        public static void ConversionTemperature()
        {
            Console.WriteLine("Enter celisius temperature");
            double c = Convert.ToInt32(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("calsius to Farhrenheit : " +f);
            c = (f - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to celisius : " +c);
        }
    }
}
