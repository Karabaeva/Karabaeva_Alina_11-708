using System;

namespace Vetvlenia.Cond6
{
    class Program
    {
        static void Coordinats(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double cos = ((x1 * x3 + y1 * y3) / Math.Sqrt(Math.Abs(x1 * x1 + y1 * y1) + (Math.Sqrt(x3 * x3 + y3 * y3)))); // угол между векторами
            double Length1 = Math.Sqrt(Math.Abs(x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)); //длина вектора с координатами х1,у1;х2,у2
            double Length2 = Math.Sqrt(Math.Abs(x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2)); //длина второго вектора с координатами х2,y2;x3,y3
            if (cos == 0 && Length1 == Length2) // если косинус м/у векторами равен 0, то есть 90 градусов и длины вектором равны
            {
                Console.WriteLine("Точки являются вершинами квадрата");
            }
            double diagonal1 = Length1*Math.Sqrt(2);
            double x4 = x2 + diagonal1 * Math.Sin(45); // по правилу нахождения конечной точки вектора на осях абсцисс и ординат
            // зная начальные точки, длину вектора(диагонал)
            //и угол, под котором он направлен, в нашем случае так как это квадрат под 45-ю градусами
            double y4 = y2 + diagonal1 * Math.Sin(45);
            Console.WriteLine("х4,у4 координаты четвертой точки");

        }
    }
}
