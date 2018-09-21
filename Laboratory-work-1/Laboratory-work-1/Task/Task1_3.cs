using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1
{
    public class Task1_3 : ITask
    {
        private double X { get; set; }
        private readonly int A = 3;

        public Task1_3(double X)
        {
            this.X = X;
        }

        public void Print()
        {
            Console.WriteLine($"Y = {ResultTask()}");
        }

        public double ResultTask()
        {
            double d = Denominator(X);
            double n = Numerator(X);
            if (d == 0)
                return -1;
            else return n / d;
        }

        private double Numerator(double X)
        {
            return X * Math.Log10(X + 1) + Math.Log10(X + 1) +
                   X * Math.Log10(A) + Math.Log10(A) +
                   Math.Pow(A, X + 1) * Math.Log10(X + 1) +
                   Math.Pow(A, X + 1) * Math.Log10(A);
        }

        private double Denominator(double X)
        {
            return Math.Log10(A) + Math.Log10(X + 1);
        }
    }
}
