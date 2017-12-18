using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    [TestClass]
    public class IsPrime_Test
    {
        Problem3 _problem3;

        [TestMethod]
        public void IsPrime_2_True()
        {
            bool p = _problem3.IsPrime(2);
            Assert.IsTrue(p);
        }

        [TestMethod]
        public void IsPrime_3_True()
        {
            bool p = _problem3.IsPrime(3);
            Assert.IsTrue(p);
        }



        [TestMethod]
        public void IsPrime_101_True()
        {
            bool p = _problem3.IsPrime(101);
            Assert.IsTrue(p);
        }

        [TestMethod]
        public void IsPrime_LessThat2_False()
        {
            bool p = _problem3.IsPrime(1);
            Assert.IsFalse(p);
            
            p = _problem3.IsPrime(0);
            Assert.IsFalse(p);
            
            p = _problem3.IsPrime(-1);
            Assert.IsFalse(p);
        }


        [TestInitialize]
        public void SetUp()
        {
            _problem3 = new Problem3();
        }
    }
}
