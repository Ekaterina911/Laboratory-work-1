using System;

namespace Laboratory_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитаем отдельно числитель и знаменатель для того чтобы исключить 0

            double Y = 0.0, Numerator = 0.0, Denominator = 0.0;     //Переменные, Numerator - числитель, Denominator - знаменатель 
            Console.WriteLine("Введите Х из предложенных вариантов: -5,-2,2,5");
            int X = Convert.ToInt32(Console.ReadLine());

            /*                                                      //Преобразование через TryParse
            string S = Console.ReadLine();
            int X;
            if (Int32.TryParse (S, out X))
            */

            Numerator = 2 * Math.Pow(X, 3) + 6 * Math.Pow(X, 2) - 8 * X + 4;
            Denominator = ((-4) * Math.Pow(X, 3)) + (8 * Math.Pow(X, 2)) - (Math.Pow(X, 5)) + 2 * Math.Pow(X, 4);

            if (Denominator == 0)                                   //если знаменатель будет равен 0
                Console.WriteLine("Знаменатель равен нулю");        //то 
            else
            {                                                       //иначе считаем Y
                Y = Numerator / Denominator;
                Console.Write("Y = {0, 6:F3}", Y);
            }
            Console.ReadKey();
        }
    }
}
