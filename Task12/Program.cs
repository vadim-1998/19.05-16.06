﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int Remainder(int num1, int num2)
{
    int remainder = num1 % num2;
    return remainder;
}

Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());


int remainder = Remainder(number1, number2);
if (remainder == 0)
{
    Console.WriteLine($"число {number1} кратно числу {number2}");

}
else
{
    Console.WriteLine($"число {number1}  не кратно числу {number2} остаток {remainder}");
}