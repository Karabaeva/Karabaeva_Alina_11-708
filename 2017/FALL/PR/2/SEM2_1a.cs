using System;


namespace SEM1a
{
    class Program
    {
        static int k;
        static double Factorial(int f)
        {
            if ((f == 0) || (f ==1)) return 1;
            return f * Factorial((f - 1));

        }
        static double Function(double x, int k)
        {
            int a = int.Parse(Console.ReadLine());
			// ---check--- не надо было считать степень x, а надо было домножать предыдущий результат на x.
            return Math.Pow((-1 + a), k) * x * (Math.Pow(Math.Log(x), k)) / Factorial(k);

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
