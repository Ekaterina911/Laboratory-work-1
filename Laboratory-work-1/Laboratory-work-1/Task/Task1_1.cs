using System;

namespace Laboratory_work_1
{
    public class Task1_1 : ITask
    {
        private double X { get; set; }

        public Task1_1(double X)
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

        public double Numerator(double X)
        {
            return 2 * Math.Pow(X, 3) + 6 * Math.Pow(X, 2) - 8 * X + 4;
        }

        public double Denominator(double X)
        {
            return ((-4) * Math.Pow(X, 3)) + (8 * Math.Pow(X, 2)) - (Math.Pow(X, 5)) + 2 * Math.Pow(X, 4);
        }
    }
}
