namespace LogicalPrograms
{
   class Programs  
   {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series");
                Console.WriteLine(" 2.PerfectNumber \n 3. PrimeNumber \n 4. ReverseNumber \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LogicalProblems series = new LogicalProblems();
                        series.FibonacciSeries();
                        break;

                    case 2:
                        LogicalProblems num = new LogicalProblems();
                        num.PerfectNumber();
                        break;

                    case 3:
                        LogicalProblems number = new LogicalProblems();
                        number.PrimeNumber();
                        break;

                    case 4:
                        LogicalProblems rev = new LogicalProblems();
                        rev.ReverseNumber();
                        break;




                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}