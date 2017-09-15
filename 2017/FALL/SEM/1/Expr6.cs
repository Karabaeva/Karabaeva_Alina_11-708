using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammm
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            double P = (x2 - x);
            double Q = (y2 - y);
            double A = Math.Sqrt((P * P) + (Q * Q));
            Console.WriteLine(A);

        }
    }
}
