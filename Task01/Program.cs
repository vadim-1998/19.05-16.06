// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число
// квадратом второго
// a = 25, b = 5 -> да
// a =2, b = 10 -> нет
// a = 9,b = -3 -> да
// a = -3,b = 9 -> нет

Console.WriteLine("Введите  число");

int number1 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  число");

int number2 =  Convert.ToInt32(Console.ReadLine());


if(number1 == number2 * number2)
{
    Console.WriteLine("Да{number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine("Нет{number1} не является квадратом числа {number2}");
}