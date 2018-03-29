using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {

        static int k = int.Parse(Console.ReadLine());
        public static int K { get => k; set => k = value; }

        static void Main(string[] args)
        {
           
            List<int> numbers = new List<int>() { 5,8,7,2,10,4,8,5,2,4,7,6 };
            SeparationOfElements(numbers);
            Console.ReadLine();
        }
        static void SeparationOfElements(IEnumerable<int> num)
        {
            var evemelem = num.Where(t => t % 2 == 0).Select(t => t);
            int[] evenArray = evemelem.ToArray();

            var morethan = num.Skip(K);
            int[] thanArray = morethan.ToArray();
            DifferenceOfSets(evenArray, thanArray);
        }
        static void DifferenceOfSets(int[] first, int[] second)
        {
            var difference = second.Except(first).Reverse();
            foreach (var end in difference)
                Console.WriteLine(end);
            
        }
       
    }
}
