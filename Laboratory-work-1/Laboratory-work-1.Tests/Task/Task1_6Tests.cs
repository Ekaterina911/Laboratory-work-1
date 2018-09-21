using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    [TestClass]
    public class Task1_6Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double X = 0;
            double expected = 1;

            Task1_6 y = new Task1_6(X);
            double actual = y.ResultTask();

            Assert.AreEqual(expected, actual);
        }
    }
}
