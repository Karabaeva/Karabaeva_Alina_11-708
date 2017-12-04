using System;


namespace SEM2
{
    class Program
    {
	// ---check--- можно воспользоваться суммой арифм.прогресси
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sumt=0;
            for (int t = a-1; t > 0; t--)
              sumt += t;
             Console.WriteLine(sumt);
            




        }
    }
}
