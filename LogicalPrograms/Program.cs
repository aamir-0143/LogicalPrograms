namespace LogicalPrograms
{
   class Programs  
   {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LogicalProblems series = new LogicalProblems();
                        series.FibonacciSeries();
                        break;
 
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}