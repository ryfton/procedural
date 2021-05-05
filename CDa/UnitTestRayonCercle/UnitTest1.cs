using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayonCercle;

namespace UnitTestRayonCercle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double rayonc = 10;
            double angl = 45;
            double resulta = 39.269908169872;
            double testResulta= Program.AireCirculaire(rayonc, angl);

            Assert.AreEqual(resulta, angl);

        }

      
    }
}
