using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
# Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600,851,475,143 ?
 */

namespace Problem3
{
    public static class PrimeFactor
    {
        public static long LargestPrimeFactor(long num)
        {

            long largest_factor = 1;

            // remove any factors of 2 first
            while (num % 2 == 0)
            {
                largest_factor = 2;
                num = num / 2;
            }

            // now look at odd factors
            long divisor = 3L;
            while (num != 1)
            {
                while (num % divisor == 0)
                {
                    largest_factor = divisor;
                    num = num / divisor;
                }
                divisor += 2;
            }

            return largest_factor;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindLargestPrimeFactor_Test()
        {
            Assert.AreEqual(2, PrimeFactor.LargestPrimeFactor(2));
            Assert.AreEqual(5, PrimeFactor.LargestPrimeFactor(5));
            Assert.AreEqual(5, PrimeFactor.LargestPrimeFactor(10));
            Assert.AreEqual(29, PrimeFactor.LargestPrimeFactor(13195));
            Assert.AreEqual(6857, PrimeFactor.LargestPrimeFactor(600851475143));
        }
    }
}