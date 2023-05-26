// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1




int ShowSecondDigit(int num)
{
    int showSecondDigit = num / 10 % 10;
    return showSecondDigit;
}

Console.WriteLine("Введите трехзначное  число");

int number = Convert.ToInt32(Console.ReadLine());

int showSecondDigit = ShowSecondDigit(number);


showSecondDigit = ShowSecondDigit(number);
Console.WriteLine($"вторая цифра числа -> {showSecondDigit}");




