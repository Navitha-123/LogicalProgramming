﻿namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("choose option 1.Fibonacci \t 2.PerfectNumber \t 3.Primenumber \t 4.Reversenumber \t 5. Dayofweek \t 6.Temperature \t 7.MonthlyPayment \t 8.Squareroot  \t 9. Binaryvalue \t 10.BinarySwap \t 11.Coupnnumber \t 12.stopwatch");
            int option = Convert.ToInt32(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    UC1Fibonacci.FibonacciNumbers(9);
                    break;
                case 2:
                    UC2PerfectNumber.NumberPerfect();
                        break;
                case 3:
                    UC3PrimeNumber.CalculatePrimeNumber();
                    break;
                case 4:
                    UC4ReverseNumber.ReversingNumbers();
                    break;
                case 5:
                    DayOfWeek.WeekOfDay();
                    break;
                case 6:
                    TemperatureConversion.ConversionTemperature();
                    break;
                case 7:
                    MonthlyPayment.CalculatePaymentMonth();
                    break;
                case 8:
                    Squareroot.RootOfSquare();
                    break;
                case 9:
                    BinaryValue.BinaryConversion();
                    break;
                case 10:
                    SwapBinaryValues.BinarySwap(5);
                    break;
                case 11:
                    UC5Coupn.Coupnnumber();
                    break;
                case 12:
                    UC6StopWatch.Checkstopwatch();
                    break;

            }
        }
    }
}