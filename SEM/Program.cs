using System;

namespace MyProgramm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = (a / 100); //b=1
           
            b += (a % 10) * 100; // 
            b += (a % 100-3) ; 
           
            Console.WriteLine(b);
            Console.WriteLine(a);
            
            
            
            
            
           Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
