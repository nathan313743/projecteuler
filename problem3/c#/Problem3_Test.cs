using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimeNumber_True()
        {
            Assert.IsTrue(Problem3.IsPrimeNumber(2));
            Assert.IsTrue(Problem3.IsPrimeNumber(3));
            Assert.IsTrue(Problem3.IsPrimeNumber(5));
            Assert.IsTrue(Problem3.IsPrimeNumber(7));
            Assert.IsTrue(Problem3.IsPrimeNumber(11));
        }

        [TestMethod]
        public void IsPrimeNumber_False()
        {
            Assert.IsFalse(Problem3.IsPrimeNumber(4));
            Assert.IsFalse(Problem3.IsPrimeNumber(6));
            Assert.IsFalse(Problem3.IsPrimeNumber(8));
            Assert.IsFalse(Problem3.IsPrimeNumber(9));
            Assert.IsFalse(Problem3.IsPrimeNumber(10));
        }

        [TestMethod]
        public void IsFactor_False()
        {
            Assert.IsFalse(Problem3.IsFactor(10, 3));
            Assert.IsFalse(Problem3.IsFactor(100, 9));
            Assert.IsFalse(Problem3.IsFactor(0, 0));
            Assert.IsFalse(Problem3.IsFactor(5, 2));
        }


        [TestMethod]
        public void IsFactor_True()
        {
            Assert.IsTrue(Problem3.IsFactor(10, 5));
            Assert.IsTrue(Problem3.IsFactor(100, 20));
            Assert.IsTrue(Problem3.IsFactor(1, 1));
            Assert.IsTrue(Problem3.IsFactor(46, 2));
        }

        [TestMethod]
        public void FindLargestPrimeFactor_Test()
        {
            Assert.AreEqual(2, Problem3.FindLargestPrimeFactor(2));
            Assert.AreEqual(5, Problem3.FindLargestPrimeFactor(5));
            Assert.AreEqual(5, Problem3.FindLargestPrimeFactor(10));
            Assert.AreEqual(29, Problem3.FindLargestPrimeFactor(13195));
            Assert.AreEqual(6857, Problem3.FindLargestPrimeFactor(600851475143));
        }

        [TestMethod]
        public void FindLargestPrimeFactor2_Test()
        {
            Assert.AreEqual(2, Problem3.FindLargestPrimeFactor(2));
            Assert.AreEqual(5, Problem3.FindLargestPrimeFactor2(5));
            Assert.AreEqual(5, Problem3.FindLargestPrimeFactor2(10));
            Assert.AreEqual(29, Problem3.FindLargestPrimeFactor2(13195));
            Assert.AreEqual(6857, Problem3.FindLargestPrimeFactor2(600851475143));
        }
    }
}
