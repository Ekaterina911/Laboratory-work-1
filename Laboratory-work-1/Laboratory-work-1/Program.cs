using System;

namespace Laboratory_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1_1 one = new Task1_1(-5);
            one.Print();

            Task1_2 two = new Task1_2(4);
            two.Print();

            Task1_3 three = new Task1_3(4);
            three.Print();

            Console.ReadKey();
        }
    }
}
