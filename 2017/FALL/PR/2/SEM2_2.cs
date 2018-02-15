using System;


namespace SEM2_2
{
    class Program
    {
        static double Function(int k)
        {
            return (1 / ((4 * k - 2) * (4 * k - 1))) + (2 * Math.Log(2));
        }
		// ---check--- абсолютено неинформативные названия методов
        static double Fun1(double e)
        {
            double previous = 0;
            int k = 1;
            double current = Function(k);
            double sum = current;
            k++;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;

                current = Function(k);
                sum += current;
                k++;
            }

            return sum;
        }
        // ---check--- абсолютено неинформативные названия методов
		static double Fun(double e)
        {
            return (8 * Fun1(e));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность e > 0,005");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine(Fun(e));

        }
    }
}
