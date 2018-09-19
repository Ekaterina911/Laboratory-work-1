using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    [TestClass()]
    public class Task1_4Tests
    {
        [TestMethod()]
        public void ResultTaskTest()
        {
            double X = 4;
            double expected = -8685.2491680350828226235;

            Task1_4 four = new Task1_4(X);
            double actual = four.ResultTask();

            Assert.AreEqual(expected, actual);
        }
    }
}