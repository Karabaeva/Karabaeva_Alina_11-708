using System;


namespace ulearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первые три цифры");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последние три цифры");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if ((a == x & b == y) == true)
            {
                if ((a + b + c) - (x + y + z) == 1)
                {
                    Console.WriteLine("Следующий билет");
                }
                else if ((x + y + z) - (a + b + c) == 1)
                {
                    Console.WriteLine("Предыдущий билет");
                }
                else
                { Console.WriteLine("Ни следующий билет, ни предыдущий не являются счастливыми");
                }
            }


        }
    }
}
