using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class LogicalProblems 
    {
        public void FibonacciSeries()
        {
            int first = 0, second = 1, third = 0;
            Console.WriteLine("Enter the number of series :");
            int series = Convert.ToInt32(Console.ReadLine());
            if (series <= 1)
            {
                Console.WriteLine(first);
                return;
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < series; i++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
        }
        public void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0} ", i);
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect number");
            }
        }
    }
}
