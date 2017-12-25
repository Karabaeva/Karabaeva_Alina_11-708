using System;
namespace Semistrovka5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool simple = true;

            if (n % 2 == 0) sum += 2;
            for (int i = 1; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0 && i != 1)
                {
                    simple = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0 && j != 1)
                        {
                            simple = false;
                            break;
                        }
			// ---check--- зачем это?
                        simple = true;
                    }
                    if (simple) sum += i;
                }
            }

            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
    
}
