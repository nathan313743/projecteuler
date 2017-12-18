using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Problem3
    {
        public bool IsFactor(int number, int factor)
        {
            return number % factor == 0;
        }

        private bool IsUnderLimit(int n)
        {
            if (n < 2)
            {
                return true;
            }

            return false;
        }

        public int LargestPrimeFactor(int n)
        {
            int largestPrimeFactor = 0;

            if(IsUnderLimit(n))
            {
                return largestPrimeFactor;
            }

            int maxLimit = n / 2;

            for (int i = 1; i <= maxLimit; ++i)
            {
                if(IsFactor(n, i) && IsPrime(i))
                {
                    largestPrimeFactor = i;
                }
            }

            if (largestPrimeFactor == 0)
            {
                largestPrimeFactor = n;
            }

            return largestPrimeFactor;
        }

        public bool IsPrime(int n)
        {
            if(IsUnderLimit(n))
            {
                return false;
            }

            int squareRoot = (int)Math.Sqrt(n);
            int i = 2;
            
            while (i < squareRoot)
            {
                if(n % i == 0)
                {
                    return false;
                }

                ++i;
            }

            return true;
        }
    }
}
