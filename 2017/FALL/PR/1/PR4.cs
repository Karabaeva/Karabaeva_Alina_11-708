using System;


namespace PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int Lenght = 0;
            if (b % 2 == 0)
            {
                while (b != 0)
                {
                    b -= 2;
                    Lenght += 1;
                }

                Console.WriteLine(Lenght);
            }
            else
                b -= 1;
              while (b != 0)
            {
                b -= 2;
                Lenght += 1;
            }
            Console.WriteLine(Lenght);










        }
    }
}
