// Задача 2: Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите координаты точки X и Y: ");

string[] coordinates = Console.ReadLine().Split(' ')
int X = Convert.ToInt32(coordinates[0]);
int Y = Convert.ToInt32(coordinates[1]);

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Точка находится на оси координат");
}

