using NUnit.Framework;
using Moyenne;


namespace UnitTestmoyen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDouble()

        {
            double moyenne = Program.Moyenne(2.2, 2.6);
            Assert.AreEqual(moyenne, 2.4);


        }
    }
}
