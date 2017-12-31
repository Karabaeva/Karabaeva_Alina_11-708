using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class Program
{
    static void PrintOnPosition(int x, int y, string c,
    ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str,
    ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static string Name;

    public int[,] arr = new int[3, 3];
    public void name() //function for initializing the array
    {
        arr[0, 0] = 1;
        arr[0, 1] = 4;
        arr[0, 2] = 2;
        arr[1, 0] = 3;
        arr[1, 1] = 5;
        arr[1, 2] = 8;
        arr[2, 0] = 6;
        arr[2, 1] = 7;
        arr[2, 2] = 0;
    }
    static void Main()
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n WW WW ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WW ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WW EEEEEEE LL CCCCCC OOOOOO MMM MMM EЕЕЕЕЕЕЕЕЕ ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WW WW EE LL CC O O MM M M MM EEE");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WWWW WW EEEE LL CC O O MM M MM EE");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WW WW WW EE LL CC O O MM MM EEЕ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" WW WW EEEEEEE LLLLLL CCCCCC OOOOOO MM MM EEEEEEEE");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ваша задача, не дать смайлику столкнуться с летающей веткой");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n Управление: \n Вверх-стрелка наверх\n Вниз-Стрелка вниз ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n Проект- ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" Николаева Ольга ");
        Console.WriteLine(" Карабаева Алина");
        Console.WriteLine(" гр.11-709");
        Console.WriteLine(" гр.11-708");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите ваше имя: ");
        Console.ForegroundColor = ConsoleColor.Red;

        Name = Console.ReadLine();

        Program p = new Program();

        p.name();
        Console.ReadLine();

        // начальная скорость
        double speed = 50.0;
        double acceleration = 0.5;

        // область движения героя
        int playfieldWidth = 20;
        //Жизни
        int livesCount = 5;

        /// Размер игрового окна
        Console.BufferHeight = Console.WindowHeight = 15;
        Console.BufferWidth = Console.WindowWidth = 43;
        Object userCar = new Object();
        userCar.x = 30;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = "~(^_^)~";
        userCar.color = ConsoleColor.Yellow;

        // Подключение рандомного появления препяствий
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();
        while (true)
        {
            speed += acceleration;
            if (speed > 400)
            {
                speed = 400;
            }

            bool hitted = false;
            {
                // Изменение
                int chance = randomGenerator.Next(0, 100);
                if (chance < 50)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = "*";
                    newObject.y = randomGenerator.Next(0, playfieldWidth);
                    newObject.x = 0;
                    objects.Add(newObject);
                }
                else
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = "Y";
                    newObject.y = randomGenerator.Next(0, playfieldWidth);
                    newObject.x = 0;
                    objects.Add(newObject);
                }

            }
            // движение героя по оси у
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (userCar.y - 1 >= 0)
                    {
                        userCar.y = userCar.y - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (userCar.y + 1 < playfieldWidth)
                    {
                        userCar.y =
                        userCar.y + 1;
                    }
                }
            }
            // как будут двигаться припятствия
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldCar = objects[i];
                Object newObject = new Object();
                newObject.y = oldCar.y;
                newObject.x = oldCar.x + 2;
                newObject.c = oldCar.c;
                newObject.color = oldCar.color;
                if (newObject.c == "*" && newObject.y == userCar.y && newObject.x == userCar.x)
                {
                    speed -= 20;
                }

                if (newObject.c == "Y" && newObject.y == userCar.y && newObject.x == userCar.x)
                {
                    livesCount--;
                    hitted = true;
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }

                    // проверка выхода из игры
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newObject.y < Console.WindowHeight - 1)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;
            Console.Clear();
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(userCar.x, userCar.y, "~(X_X)~", ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            }
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }

            // Draw info
            PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnPosition(8, 6, "Acceleration: " + acceleration, ConsoleColor.White);
            //Console.Beep();
            Thread.Sleep((int)(600 - speed));
        }
    }
}


