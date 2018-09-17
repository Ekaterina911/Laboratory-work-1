using System;

namespace Laboratory_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1_1
            #region 
            // Посчитаем отдельно числитель и знаменатель для того чтобы исключить 0

            double Y = 0.0, Numerator = 0.0, Denominator = 0.0;     //Переменные, Numerator - числитель, Denominator - знаменатель 
            Console.WriteLine("Введите Х из предложенных вариантов: -5,-2,2,5");
            int X = Convert.ToInt32(Console.ReadLine());

            Numerator = 2 * Math.Pow(X, 3) + 6 * Math.Pow(X, 2) - 8 * X + 4;
            Denominator = ((-4) * Math.Pow(X, 3)) + (8 * Math.Pow(X, 2)) - (Math.Pow(X, 5)) + 2 * Math.Pow(X, 4);

            if (Denominator == 0)                                   //если знаменатель будет равен 0
                Console.WriteLine("Знаменатель равен нулю");        //то 
            else
            {                                                       //иначе считаем Y
                Y = Numerator / Denominator;
                Console.Write("Y = {0, 6:F3}", Y);
            }
            #endregion

            //Task 1_2
            #region
            double y = 0.0, a = 1.5, x;
            Console.WriteLine("Выберете x из предложенных вариантов:0.001, 0.1, 1, 4");
            x = Convert.ToDouble(Console.ReadLine());

            y = (Math.Pow(a, x) * Math.Pow(x, a) + 
                2 * Math.Pow(a, 2 * x) * Math.Pow(x, 2 * a) - 
                2 * Math.Pow(a, x) * Math.Pow(x, 2 * a) - 
                4 * Math.Pow(a, 2 * x) * Math.Pow(x, 2 * a)) / 
                (Math.Log10(a) + Math.Log10(x));

            Console.WriteLine("y= {0,6:F3}", y);
            #endregion

            Console.ReadKey();
        }
    }
}
