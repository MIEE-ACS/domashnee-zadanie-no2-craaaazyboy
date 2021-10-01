using System;

namespace  DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод значение Y зависящих от X функцией, заданной графиком");
            for (double x1 = -6; x1 <= 12; x1 = x1 +0.1)
            {
                uslovie(x1);
            }
            Console.WriteLine("Введите значение X :");
            double coordinate = double.Parse(Console.ReadLine());
            uslovie(coordinate);
        }

        private static void uslovie(double x)
        {
            double y=0;
            if (Math.Round(x, 2) <= -4)
            {
                y = -2;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (Math.Round(x,2) == -4)
            {
                Console.WriteLine("Разрыв первого рода");
            }
            if (Math.Round(x, 2) >= -4 && x <= 0)
            {
                y = x/4;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (x > 0 && x <= 2)
            {
                y = Math.Pow(x, 2);
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (x > 2)
            {
                y = -x/2+5; ;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
        }
    }
}
