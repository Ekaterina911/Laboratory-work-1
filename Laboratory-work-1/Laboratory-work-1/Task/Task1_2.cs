using System;

namespace Laboratory_work_1
{
    public class Task1_2 : ITask
    {
        private double X { get; set; }
        private readonly double A = 1.5; 

        public Task1_2(double X)
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
            return (1 - Math.Sqrt(Math.Abs(Math.Log(X,2))) + 
                    25 * Math.Pow(10, -5) * Math.Log10(X));
        }

        public double Denominator(double X)
        {
            return (Math.Log(X, 2) + 0.00025 * Math.Log10(X));
        }

    }
}
