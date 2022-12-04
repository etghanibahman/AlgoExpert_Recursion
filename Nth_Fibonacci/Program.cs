using System;

namespace Nth_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
            int n = 5;
            Console.WriteLine($"Nth Fibonacci for {n} is : {GetNthFib(n)}");
        }

        public static int GetNthFib(int n)
        {
            #region Non-Recursive
            int[] lastTwo = new int[2] { 0, 1 };
            int counter = 3;
            while (counter <= n)
            {
                int nextFib = lastTwo[0] + lastTwo[1];
                lastTwo[0] = lastTwo[1];
                lastTwo[1] = nextFib;
                counter += 1;
            }
            return n > 1 ? lastTwo[1] : lastTwo[0]; 
            #endregion

            #region Recursion
            //if (n == 1)
            //    return 0;
            //else if (n == 2)
            //    return 1;
            //else return GetNthFib(n - 2) + GetNthFib(n - 1);
            #endregion

        }
    }
}
