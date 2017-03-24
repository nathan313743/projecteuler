using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab
{
    [TestClass]
    internal class Class1_Test
    {
        [TestMethod]
        private void Sum_Test()
        {
            Assert.AreEqual(5, Class1.Sum(10));
            Assert.AreEqual(89, Class1.Sum(11));
            Assert.AreEqual(144, Class1.Sum(12));
            Assert.AreEqual(233, Class1.Sum(13));
        }

        [TestMethod]
        private void Sum3_Test()
        {
            Assert.AreEqual(4613732L, Class1.Sum3());
        }
    }
}