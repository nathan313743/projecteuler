using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemTest
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void GetEvenSumLessThan4Million_Test()
        {
            long result = Problem.Problem2.GetEvenSumLessThan4Million();
            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void Fib4MillionLimit_Test()
        {
            //long result = Problem.Problem2.Fib4MillionLimit(5);
            //Assert.AreEqual(4613732, result);
        }
    }
}
