using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yesorno
{
    class Program
    {
        static void Main(string[] args)
        {   //Создать массив с элементами которые можно ввести через консоль
            //обходом каждого элемента массива проверять условие < или >

            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];   //Создаем массив нашей длины
            for (int i=0; i < Arr.Length; i++) 
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());// Записываем наши числа 
                Console.WriteLine(Arr[i]);
            }
            









        }
    }
}
