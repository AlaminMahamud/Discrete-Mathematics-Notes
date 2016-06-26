using System;

namespace Fibonacci
{
    class Program
    {
        private static int myInt;

        public static void Main()
        {
            for (int i = 1; i < 50; i++)
            {
               Console.WriteLine(Fibonacci_func(i));
            }
        }

        static int Fibonacci_func(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                myInt = Fibonacci_func(n - 1) + Fibonacci_func(n - 2);
            }
            return myInt;
        }
    }
    
}