﻿// Напишите программу, которая будет
// выдавать дни недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <=7)
{
 if(num ==1)
 {
Console.WriteLine("Понедельник");
 }
if(num ==2)
 {
Console.WriteLine("Вторник");
 }
else if(num ==3)
 {
Console.WriteLine("Среда");
 }
 else if(num ==4)
 {
Console.WriteLine("Четверг");
 }
else if(num ==5)
 {
Console.WriteLine("Пятница");
 }
else if(num ==6)
 {
Console.WriteLine("Суббота");
 }
else if(num ==7)
 {
Console.WriteLine("Воскресенье");
 }
}

else
{
    Console.WriteLine("Введено неверное число");
}





