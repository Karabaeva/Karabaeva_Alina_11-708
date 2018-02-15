 using System;


namespace SEM1b  //Это 3 подзадание 
{
    class Program
    {
        static int k;
        static double Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return (2 * n + 1) * Factorial(2 * (n - 1) + 1);
        }

        static double Function(double x, int k)
        {
			// ---check--- не надо было считать степень x, а надо было домножать предыдущий результат на x.
            return (Math.Pow(x, (2 * k + 1)) / Factorial(k));
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
