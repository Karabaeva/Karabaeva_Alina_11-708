using System;

namespace MyProgramm2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            b = b - a;
            a = b + a;
            b = a - b;
            Console.WriteLine(b);
            Console.WriteLine(a);

        }
    }
}
