using System;

namespace Problem
{
    public class Problem2
    {
        public static long GetEvenSumLessThan4Million()
        {
            long previousValue = 0L;
            long currentValue = 1L;
            long sum = 0L;

            while (true)
            {
                long temp = currentValue;
                currentValue = previousValue + currentValue;
                previousValue = temp;

                if (currentValue > 4000000L)
                {
                    return sum;
                }

                if (currentValue % 2 == 0)
                {
                    sum += currentValue;
                }
            }
        }
         
        public static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        // Currently produces stackoverflow
        public static long Fib4MillionLimit(int n)
        {
            if (n > 4000000L)
            {
                return n;
            }

            var v1 = Fib4MillionLimit(n + 1);
            var v2 = Fib4MillionLimit(n + 2);

            return v1 + v2;
        }
    }
}
