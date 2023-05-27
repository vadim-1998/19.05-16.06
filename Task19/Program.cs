// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());


// if (number < 1000 && number > 100000)
// {
//     Console.WriteLine("Вы ввели неверное число");
//     return;
// }

int FirstDigit(int num)
{
    int number = num / 10000;
    return number;
}

int SecondDigit(int num)
{
    int number = num / 1000 % 10;
    return number;
}

int FourthDigit(int num)
{
    int number = num / 10 % 10;
    return number;
}

int FifthDigit(int num)
{
    int number = num % 10;
    return number;
}

if (number >= 10000 && number <= 100000)
{


    if (FirstDigit(number) == FifthDigit(number) && SecondDigit(number) == FourthDigit(number))
    {
        Console.WriteLine($"{number} -> палиндром");
    }
    else
    {
        Console.WriteLine($"{number} -> не палиндром");
    }

}
else

    Console.WriteLine("Вы ввели неверное число");
    return;


