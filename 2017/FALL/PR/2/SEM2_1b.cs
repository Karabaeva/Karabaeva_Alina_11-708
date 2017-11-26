using System;


namespace Semester1b
{
    class Program
    {
        static int k;
        static double Function(double x, int k)
        {
            int n = int.Parse(Console.ReadLine());
            if (x > 1)
                return 1;
            else 
                return Math.Pow((-1), k) * Math.Pow(x, k) * (1 + n);
            // ИЛИ 
            //int n = int.Parse(Console.ReadLine());
            //if (x > 1)
            //   Console.WriteLine ("Введите число меньше 1") ;
            //else
            //    Console.WriteLine( Math.Pow((-1), k) * Math.Pow(x, k) * (1 + n));
        }
        static long Summ(double x, double e)
        {
            double previous = 0;
            double current = Function(x, 0);
            long sum = (long)current;
            int k = 1;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;
                current = Function(x, k);
                sum += (long)current;
                k++;
            }
            Console.WriteLine("Точность достигается на " + k + " шагу");
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность e");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Сумма последовательности равна " + Summ(x, e));
            Console.WriteLine("Точность достигается на " + k + " шагу");
        }
    }
}
