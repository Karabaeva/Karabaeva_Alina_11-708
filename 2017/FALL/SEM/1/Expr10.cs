using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    amount += i;
            }
                Console.WriteLine(amount); 
            


        }
    }
}
