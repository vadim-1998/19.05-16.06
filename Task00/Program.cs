﻿// Напишите программу, которая на вход
// принимет число и выдает его квадрат (число
// умноженное на само себя).
// Например
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"квадрат числа {number} = {square}");