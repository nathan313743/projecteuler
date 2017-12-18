using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    [TestClass]
    public class LargestPrimeFactor_Test
    {
        Problem3 _problem3;

        [TestMethod]
        public void LargestPrimeFactor_2_Return2()
        {
            int result = _problem3.LargestPrimeFactor(2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void LargestPrimeFactor_10_Return5()
        {
            int result = _problem3.LargestPrimeFactor(10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LargestPrimeFactor_17_Return_17()
        {
            int result = _problem3.LargestPrimeFactor(17);
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void LargestPrimeFactor_13195_Return_29()
        {
            int result = _problem3.LargestPrimeFactor(17);
            Assert.AreEqual(17, result);
        }


        [TestInitialize]
        public void SetUp()
        {
            _problem3 = new Problem3();
        }
    }
}
