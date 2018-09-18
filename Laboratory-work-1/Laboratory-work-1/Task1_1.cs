using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1
{
    class Task1_1
    {
        private double X { get; set; }

        public Task1_1(double X)
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
            return 2 * Math.Pow(X, 3) + 6 * Math.Pow(X, 2) - 8 * X + 4;
        }

        private double Denominator(double X)
        {
            return ((-4) * Math.Pow(X, 3)) + (8 * Math.Pow(X, 2)) - (Math.Pow(X, 5)) + 2 * Math.Pow(X, 4);
        }
    }
}
