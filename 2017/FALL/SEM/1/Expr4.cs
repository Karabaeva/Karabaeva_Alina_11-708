using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UleaarnSEM4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); 
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int A = ((N / X) + (N / Y) - N*(X * Y));

            Console.WriteLine(A);







        }
    }
}
