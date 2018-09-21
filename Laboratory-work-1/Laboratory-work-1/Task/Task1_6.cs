using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1
{
    public class Task1_6 : ITask
    {
        private double X { get; set; }

        public Task1_6(double X)
        {
            this.X = X;
        }

        public void Print()
        {
            Console.WriteLine($"Y = {ResultTask()}");
        }

        public double ResultTask()
        {
            return 1 + Math.Pow(X, 2) / Math.Pow(3, 2) +
                Math.Pow(X, 2) / Math.Pow(7, 2) +
                Math.Pow(X, 2) / Math.Pow(11, 2) +
                Math.Pow(X, 4) / Math.Pow(3, 2) * Math.Pow(7, 2) +
                Math.Pow(X, 4) / Math.Pow(3, 2) * Math.Pow(11, 2) +
                Math.Pow(X, 4) / Math.Pow(7, 2) * Math.Pow(11, 2) +
                Math.Pow(X, 6) / Math.Pow(3, 2) * Math.Pow(7, 2) * Math.Pow(11, 2);
        }
    }
}
