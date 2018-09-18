using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1
{
    class Task1_2
    {
        private double X { get; set; }
        private readonly double A = 1.5; 

        public Task1_2(double X)
        {
            this.X = X;
        }

        public void ResultTask()
        {
            double d = Denominator(X);
            double n = Numerator(X);
            if (d != 0)
                Console.WriteLine($"Y = {n / d}");
            else
                Console.WriteLine("Знаменатель равен 0");
        }

        private double Numerator(double X)
        {
            return (Math.Pow(A, X) * Math.Pow(X, A) +
                2 * Math.Pow(A, 2 * X) * Math.Pow(X, 2 * A) -
                2 * Math.Pow(A, X) * Math.Pow(X, 2 * A) -
                4 * Math.Pow(A, 2 * X) * Math.Pow(X, 2 * A));
        }

        private double Denominator(double X)
        {
            return (Math.Log10(A) + Math.Log10(X));
        }

    }
}
