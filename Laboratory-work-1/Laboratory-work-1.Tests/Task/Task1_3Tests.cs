using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    [TestClass()]
    public class Task1_3Tests
    {
        [TestMethod()]
        public void ResultTaskTest()
        {
            double X = 4;
            double expected = 248.0000000000000084177;

            Task1_3 three = new Task1_3(X);
            double actual = three.ResultTask();

            Assert.AreEqual(expected, actual);
        }
    }
}