using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float R = 55;
            string result = Dasha_OOP_4._1.Program.StudentRating(R);
            Assert.AreEqual("Варто більше уваги приділяти навчанню", result);

        }
    }
}
