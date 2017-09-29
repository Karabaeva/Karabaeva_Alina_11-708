using System;

namespace Vetvlenia.Cond1
{
    class Program
    {
        static bool FigureCorrect(int x, int y, string typeOfFigure)
        {
            if (typeOfFigure == "Слон") return (x == y) && ((y == 0) && !((x == 0)));
            if (typeOfFigure == "Конь") return ((x == 2) && (y == 1)) || ((x == 1) && (y == 2));
            if (typeOfFigure == "Ладья") return (((x != 0) && (y == 0) || (y != 0) && (x == 0)));
            if (typeOfFigure == "Ферзь") return ((x == 0) || (y == 0) || (x == y)) && (!(x == 0) && (y == 0));
            if (typeOfFigure == "Король") return (x == 1) && (y == 1);
            return false;
        }
           static void Main(string[] args)
           {
            Console.WriteLine("Название фигуры");
            string figure = Console.ReadLine();
            Console.WriteLine("Начальное положение фигуры");
            string start = Console.ReadLine();
            Console.WriteLine("Конечное положение фигуры");
            string finish = Console.ReadLine();

            int distanceX = Math.Abs(start[0] - finish[0]); // ось абсцисс
            int distanceY = Math.Abs(start[1] - finish[1]); // ось ординат

            Console.WriteLine(FigureCorrect(distanceX, distanceY, figure));


           }
    }
}




