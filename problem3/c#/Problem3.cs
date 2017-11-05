/*
# Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600,851,475,143 ?

 */

namespace Problem3
{
    public static class Problem3
    {

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

            long halfOfN = n / 2;

            if (halfOfN % 2 == 0)
            {
                // No point checking even numbers.
                // Therefore, we must start on an odd number
                halfOfN = halfOfN - 1;
            }

            for (long i = halfOfN; i >= 0; i = i - 2)
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