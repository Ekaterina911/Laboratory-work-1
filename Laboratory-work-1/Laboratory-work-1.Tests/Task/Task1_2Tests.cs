using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory_work_1.Tests
{
    /// <summary>
    /// Сводное описание для Task1_2Tests
    /// </summary>
    [TestClass]
    public class Task1_2Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double X = 1;
            double expected = 0;

            Task1_2 two = new Task1_2(X);
            double actual = two.ResultTask();

            Assert.AreEqual(expected, actual);
        }
    }
}
