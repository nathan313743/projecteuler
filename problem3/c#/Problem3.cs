using System;
/*
# Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600,851,475,143 ?

 */

namespace Problem3
{
    public static class Problem3
    {

        public static long FindLargestPrimeFactor2(long n)
        {
            long m = (long)Math.Sqrt(n);

            for(int i = 2; i < m; ++i)
            {
                while(n % i ==0)
                {
                    n = n / i;
                   
                    if(i == 1 || n == i)
                    {
                        return i;
                    }
                }
            } 

            return n;
        }


        public static long FindLargestPrimeFactor(long n)
        {
            if (n <= 2)
            {
                return n;
            }

            if (IsPrimeNumber(n))
            {
                return n;
            }

            long squareOfN = (long)Math.Sqrt(n);

            if (squareOfN % 2 == 0)
            {
                // No point checking even numbers.
                // Therefore, we must start on an odd number
                squareOfN = squareOfN - 1;
            }

            for (long i = squareOfN; i >= 0; i = i - 2)
            {
                if (IsFactor(n, i))
                {
                    if (IsPrimeNumber(i))
                    {
                        return i;
                    }
                }
            }

            return 0;
        }


        public static bool IsFactor(long dividend, long divisor)
        {
            if (divisor == 0)
            {
                return false;
            }

            if (dividend % divisor == 0)
            {
                return true;
            }

            return false;
        }

        //https://stackoverflow.com/questions/5811151/why-do-we-check-up-to-the-square-root-of-a-prime-number-to-determine-if-it-is-pr
        public static bool IsPrimeNumber(long n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}