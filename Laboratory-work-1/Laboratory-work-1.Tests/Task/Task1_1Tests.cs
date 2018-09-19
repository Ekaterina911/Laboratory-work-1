using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    [TestClass()]
    public class Task1_1Tests
    {
        [TestMethod()]
        public void ResultTaskTest1()
        {
            double X = 2;
            double expected = 0;

            Task1_1 one = new Task1_1(X);
            double actual = one.ResultTask();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ResultTaskTest2()
        {
            double X = -2;
            double expected = 0.21875;

            Task1_1 one = new Task1_1(X);
            double actual = one.ResultTask();

            Assert.AreEqual(expected, actual);
        }

    }
}