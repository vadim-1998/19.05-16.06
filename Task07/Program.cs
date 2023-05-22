﻿// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю
// цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трехзначное  число");
int number = Convert.ToInt32(Console.ReadLine());

if( number >= 100 && number <= 999)
{
int lastDigit = number % 10;
Console.WriteLine($"{lastDigit} является последней цифрой числа {number}");
}
else
{
    Console.WriteLine("Неверное число");
}