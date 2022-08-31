namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("choose option 1.Fibonacci \t 2.PerfectNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Fibonacci.FibonacciNumbers(9);
                    break;
                case 2:
                    PerfectNumber.NumberPerfect();
                        break;
            }
        }
    }
}