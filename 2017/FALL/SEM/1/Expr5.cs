using System;


namespace Progg
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y1 = int.Parse(Console.ReadLine());
            int Y2 = int.Parse(Console.ReadLine());
            int Years = (Y2 - Y1);
            int Visocos = ((Years / 4) + (Years / 100) + (Years / 400));
            Console.WriteLine(Visocos);

           

        }
    }
}
