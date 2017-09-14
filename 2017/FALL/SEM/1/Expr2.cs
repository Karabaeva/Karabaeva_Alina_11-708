using System;

namespace MyProgramm2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 487;
            int b = (a / 100); //b=4
            a %= 100; //a=87
            b += (a % 10) * 10; // b=84
            b += (a % 10) * 100; //b=784
            Console.WriteLine(b);

        }
    }
}
﻿