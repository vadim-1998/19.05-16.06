﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("неккоректное число");
    return;
}
string result = Coordinate(quarter);
Console.WriteLine($" четверть под номером {quarter} соответсвует координатам {result}");


string Coordinate(int q)

{
    if (q == 1) return "x > 0 && y > 0";
    if (q == 2) return "x < 0 && y > 0";
    if (q == 3) return "x < 0 && y < 0";
    if (q == 4) return "x > 0 && y < 0";
    return null;
}
