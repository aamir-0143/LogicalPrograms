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
        public void PrimeNumber() 
        {
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime number");
            }
        }
        public void ReverseNumber() 
        {
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reverse num is : " + revNum);
        }
        public void CouponNumber(int N) 
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Random random = new Random();
                int Random_generate = random.Next(999, 10000);
                if (i == 0)
                {
                    array[i] = Random_generate;
                }
                else
                {
                    int j = 0;
                    int check = 0;
                    while (j < i)
                    {
                        if (array[j] == Random_generate)
                            check = 1;
                        j++;
                    }
                    if (check == 0)
                        array[i] = Random_generate;
                    else
                        i--;
                }
            }
            Console.Write("Distinct Coupons Are:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
