using System;

namespace Laboratory_work_1
{
    public class Task2_4
    {
        public int a;
        public int b;
        public int angleC;

        public Task2_4(int a, int b, int angleC)
        {
            this.a = a;
            this.b = b;
            this.angleC = angleC;
        }

        public double Area()
        {
            return (a * b * Math.Sin(angleC * Math.PI / 180)) / 2;
        }

        public double UnknownParty()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) -
                2 * a * b * Math.Cos(angleC * Math.PI / 180));
        }

        public void AllAngle()
        {
            double angleA = angleC * a / UnknownParty();
            Console.WriteLine($"Угол A = {angleA}");
            Console.WriteLine($"Угол B = {180 - angleA - angleC}");
        }
    }
}
