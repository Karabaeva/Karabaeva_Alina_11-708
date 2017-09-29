using System;


namespace Vetvleniya
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("длина бруска равна");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ширина бруска равна");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("высота бруска равна");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("длина отверстия равна");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("ширина отверстия равна");
            int y = int.Parse(Console.ReadLine());

            if 
                (((x <= c) && (y <= b)) || ((x <= a) && (y <= b)) || ((x <= a) && (y <= c))) 
            {
                Console.WriteLine("YES");
            }
                    
            else 
            {
                Console.WriteLine("NO");
            }



        }
    }
}
