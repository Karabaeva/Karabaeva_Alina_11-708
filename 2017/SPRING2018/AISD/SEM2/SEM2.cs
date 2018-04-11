using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Sem2StoogeSort
{
    class StoogeSortAlgorithm
    {
       public static int StooogeCount = 0; //Заводим переменную для счета итераций в рекурсивных вызовах
       static void StoogeSort(int[] a , int first, int last)
        {
            
            //Сравниваем и меняем элементы на концах отрезка
            if (a[first] > a[last])
            {
                int T = a[first];
                a[first] = a[last];
                a[last] = T;
            }

            //Проверяем размер массива 
            if (last - first > 1)
            {
                StooogeCount++;
                //Узнаем чему равна одна треть 
                int onethird = (last - first + 1) / 3;
                StoogeSort(a, first, last - onethird); //Для первых 2/3 массива
                StoogeSort(a, first + onethird, last); //Для последних 2/3 массива
                StoogeSort(a, first, last - onethird); //Для первых 2/3 массива
            }
       }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива начиная с 50:");
            int sizearr = int.Parse(Console.ReadLine());
            int firstind = 0;
            int lastind = sizearr + 50 - 1;
            int[] array = new int[sizearr + 50];

            Random rand = new Random();
            for (int i = 0; i < sizearr; i++)
            {
                array[i] = rand.Next(0,10000);
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();
            StoogeSort(array, firstind, lastind);
            watch.Stop();
            var flop = watch.ElapsedMilliseconds;

            Console.WriteLine("Итог сортировки:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine( array[i]);
            }
            Console.WriteLine("Число итераций равно: " + StooogeCount);
            Console.WriteLine("Время в миллисекундах равно: " + flop);
            Console.ReadLine();

            
            // Заполнение  массива
            StreamWriter textToWrite = new StreamWriter("Stooge.txt");
            for (int i = 0; i < array.Length; i++)
            {
                textToWrite.WriteLine(array[i]);
            }
            textToWrite.Close();

            // Открытие файла в зависимости от размерности массива
            StreamReader textToRead = File.OpenText("Stooge.txt");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textToRead.ReadLine());
            }
            textToRead.Close();

        }
    }

    
}
