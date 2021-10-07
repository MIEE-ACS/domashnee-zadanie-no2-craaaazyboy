using System;

namespace  DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод значение Y зависящих от X функцией, заданной графиком");
            Console.WriteLine("ВВедите шаг");
            double st = double.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите радиус 1");
            double R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите радиус 2");
            double R2 = double.Parse(Console.ReadLine());
            for (double x1 = -7; x1 <= 3; x1 = x1 +st)
            {
                uslovie(x1,R1,R2);
            }
            do
            {
                Console.WriteLine("Введите значение X :");
                double coordinate = double.Parse(Console.ReadLine());
                uslovie(coordinate, R1, R2);
            } while (true);
        }

        private static void uslovie(double x,double R1, double R2)
        {
            double y=0;
            if (Math.Round(x, 2) >= -7 && x <= -6)
            {
                y = 1;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (x > -6 && x <= -4)
            {
                y = -x/2-2;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }
            if (Math.Round(R1, 3) < 2)
            {
                if (x > -4 && x < -2 - R1)
                {
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine(" y не существует");
                }
                if (x > -2 + R1 && x < 0)
                {
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine(" y не существует");
                }
                if (Math.Round(x, 3) >= -2 - R1 && Math.Round(x, 3) <= -2 + R1)
                {

                    y = Math.Sqrt(Math.Abs(R1 * R1 - (x + 2) * (x + 2)));
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                }
            }
                if (Math.Round(R1, 3) >= 2)
                {
                    if (Math.Round(x, 3) >= -4 && Math.Round(x, 3) <= 0)
                    {

                        y = Math.Sqrt(Math.Abs(R1 * R1 - (x + 2) * (x + 2)));
                        Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                        Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                    }
                }
            if (Math.Round(R2, 3) < 1)
            {
                if (x > 0 && x < 1 - R2)
                {
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine(" y не существует");
                }
                if (x > 1 + R2 && x < 2)
                {
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine(" y не существует");
                }
                if (Math.Round(x, 3) >= 1 - R2 && Math.Round(x, 3) <= 1 + R2)
                {

                    y = Math.Sqrt(Math.Abs(R2 * R2 - (x -1) * (x -1)));
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                }
            }
            if (Math.Round(R2, 3) >= 1)
              {
                if (Math.Round(x, 3) >= 0 && Math.Round(x, 3) <= 2)
                  {

                   y = Math.Sqrt(Math.Abs(R2 * R2 - (x -1) * (x -1)));
                    Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                    Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");

                }
             }
            if (x > 2 && x <= 3)
            {
                y = -x + 2;
                Console.Write($"значение X:{string.Format("{0:0.000}", x)}");
                Console.WriteLine($"  значение Y:{string.Format("{0:0.000}", y)}");
            }


        }
    }
}
