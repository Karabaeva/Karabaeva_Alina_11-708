using System;
namespace SEM2_3
{
    class Program
    {

        static double Function(double x)
        {
            return (-(Math.Sin(Math.Tan(x))));
        }
        static double LeftTriangles(double n) //Часть 1
        {
            double sum = 0;
            double i = 2;
            while (i < 3)
            {
                sum += 1.0 / n * Function(i);
                i += 1.0 / n;
            }
            return sum;
        }
        static double RightTriangles(double n) // Часть 2
        {
            double sum = 0;
            double i = 2 + 1.0 / n;
            while (i <= 3)
            {
                sum += 1.0 / n * Function(i);
                i += 1.0 / n;
            }
            return sum;
        }
        static double Trapeze(double n)  // Часть 3
        {
            double sum = 0;
            double i = 2;
            while (i < 3)
            {
                sum += 1.0 / n * ((Function(i) + Function(i + 1.0 / n)) / 2);
                i += 1.0 / n;
            }
            return sum;   
        }
         static double Simpson(int n)   //Часть 4
         {
            int b = 3;
            int a = 2;
            double h = (b - a) / n; //шаг
            n /= 2;
            double sum1 = 0;
              for (int i = 1; i<n; i++)
                   sum1 += Function(a + 2 * i* h);
            double sum2 = 0;
               for (int i = 1; i <= n; i++)
                     sum2 += Function(a + (2 * i - 1) * h);
              return n / 3 * (Function(a) + Function(b) + 2 * sum1 + 4 * sum2);  
         }

        static double RandomMK(double min, double max, Random random)  // Часть 5
        {
            return random.NextDouble() * (max - min) + min;

        }
        static double MonteKarlo(double n)
        {
            int koll = 0;   //точки, количесто которых ордината меньше чем у функции
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                double x1 = RandomMK(2, 3, random);
                double y1 = RandomMK(0, 0.48, random);
                if (y1 <= Function(x1)) koll++;
            }
            n = 1.0 / n;
            return koll * n;
        }
        //просто метод для удобного вызова других методов
        static double V(int p, int n)
        {
            if (p == 1) return LeftTriangles(n);
            else if (p == 2) return RightTriangles(n);
            else if (p == 3) return Trapeze(n);
            else if (p == 4) return Simpson(n);
            else return MonteKarlo(n);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите формулу, по которой нужно вычислить приближенное значение интеграла(напишите число).");
            Console.WriteLine("1) левых прямоугольников;");
            Console.WriteLine("2) правых прямоугольников;");
            Console.WriteLine("3) трапеций;");
            Console.WriteLine("4) Симпсона;");
            Console.WriteLine("5) Монте-Карло.");

            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число отрезков/итераций n.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(V(p, n));
        }
    }
}

