using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab
{
    internal class Class1
    {
        public static int Sum(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Sum(n - 1) + Sum(n - 2);
        }

        public static long Sum2(int n)
        {
            if (n > 4000000L)
            {
                return n;
            }

            var v1 = Sum2(n + 1);
            var v2 = Sum2(n + 2);

            return v1 + v2;
        }

        public static long Sum3()
        {
            long i = 0L;
            long j = 1L;
            long sum = 0L;

            while (true)
            {
                long temp = j;
                j = i + j;
                i = temp;

                if (j % 2 == 0)
                {
                    if (j > 4000000L)
                        return sum;

                    sum += j;
                }
            }
        }
    }
}