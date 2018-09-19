using System;

namespace Laboratory_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1_5 f = new Task1_5(4);
            //f.Print();
            Console.WriteLine($"Числитель: {f.Numerator(4)}");
            Console.WriteLine($"Знаменатель: { f.Denominator(4)}");
            int A = 2;
            double X = 4;
            //Console.WriteLine(Math.Pow(A, Math.Pow(X, A)));
            //Console.WriteLine(Math.Pow(X, Math.Pow(A, A * X)));
            double y = Math.Pow(A, Math.Pow(X, A)) *
       Math.Pow(X, Math.Pow(A, A * X));

            Console.WriteLine($"Числитель   : {y}");

            Console.ReadKey();
        }
    }
}
