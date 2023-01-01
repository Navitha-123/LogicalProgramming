using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class UC6StopWatch
    {
        public static void Checkstopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
        validation1:
            Console.WriteLine("to start watch enter S");
            char start = Convert.ToChar(Console.ReadLine());

            stopwatch.Start();
            if(start == 's' || start == 'S')
            {
                validation2:
                Console.WriteLine("To stop watch enter Q");
                char end = Convert.ToChar(Console.ReadLine());  
                if(end =='q' || end == 'Q')
                {
                    stopwatch.Stop();
                    Console.WriteLine("stopwatch stopped,the time:" +stopwatch.Elapsed);
                }
                else
                {
                    Console.WriteLine("wrong input");
                    goto validation2;
                }
            }
            else
            {
                stopwatch.Stop();
                Console.WriteLine("enter corrct input");
                goto validation1;
            }
        }
    }
}
