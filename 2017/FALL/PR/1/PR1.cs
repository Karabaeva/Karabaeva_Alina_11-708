using System;
namespace Semistrovka1
{
    class Program
    {
        static void Main(string[] args)
        {
            char lit1, num1, lit2, num2;
            lit1 = (char)Console.Read();
            num1 = (char)Console.Read();
            Console.ReadLine();
            lit2 = (char)Console.Read();
            num2 = (char)Console.Read();

            bool possible = false;

            if (Math.Abs(num1 - num2) <= 2)
            {
                if (Math.Abs(lit1 - lit2) <= 1 && Math.Abs(num1 - num2) == 1)
                    possible = true;
                else if ((num1 == '2' || num1 == '7') && Math.Abs(lit1 - lit2) == 0)
                    possible = true;
            }
            if (possible) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }

    }
}
    

