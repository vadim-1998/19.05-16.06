// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int Div = number % 2;

if( Div == 0)
{
    Console.WriteLine("да");
}
else
Console.WriteLine("нет");