using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    [TestClass()]
    public class Task1_5Tests
    {
        [TestMethod()]
        public void ResultTaskTest()
        {
            double X = 4;
            double expected = 13355637471071225126423931515722554897411352724014212858744092333045803858750303603351283347590378511628981150567083381395178964979993470452478654262869760.9961089494163424;

            Task1_5 four = new Task1_5(X);
            double actual = four.ResultTask();

            Assert.AreEqual(expected, actual);
        }


    }
}