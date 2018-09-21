using System;

namespace Laboratory_work_1
{
    public class Task1_5 : ITask
    {
        private double X { get; set; }
        private readonly int A = 2;

        public Task1_5(double X)
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
                return 0;
            else return n / d;
        }

        private double Numerator(double X)
        {
            return Math.Pow(A, Math.Pow(X, A)) *
                   Math.Pow(X, Math.Pow(A, A * X));
        }

        private double Denominator(double X)
        {
            return Math.Pow(A, A * X) + 
                   Math.Pow(X, A * X);
        }
    }
}
