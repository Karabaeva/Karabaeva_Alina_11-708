using System;


namespace PR6
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int i, j, k;
            i = j = k = 0;
            for (int a = 1; a < 999; a++)
            {
                for (int b = 1; b < 999; b++)
                {
                    c = 1000 - a - b;
                    if (c < a + b && b < a + c && a < b + c)
                    {
                        if (a * a + b * b == c * c)
                        {
                            i = a;
                            j = b;
                            k = c;
                        }
                    }
                }
            }
            Console.WriteLine(i * j * k);
            







        }
    }
}
