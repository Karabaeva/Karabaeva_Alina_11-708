using System;


namespace E12
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double v1 = (double)h / t;
            double tmax, tmin;
            if (v1 <= x)
            {
                tmax = h / (x + 1);
                tmin = 0;
                Console.WriteLine(tmin);
                Console.WriteLine(tmax);
                
            }
            else
            {
                tmax = t;
                tmin = (h - x * t) / (v - x);
                Console.WriteLine(tmin);
                Console.WriteLine(tmax);
            }
        }
}   }
