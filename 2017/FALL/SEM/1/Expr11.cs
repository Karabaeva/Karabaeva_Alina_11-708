using System;


namespace Expr11
{
    class Program
    {
        static void Main(string[] args)
       {
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            if ((minute * 6) < 180 || minute*6==180)
                Console.WriteLine((minute * 6) - (hours * 30));
            else Console.WriteLine((360 - minute * 6) + (360- hours * 30));



        }
        }
}
