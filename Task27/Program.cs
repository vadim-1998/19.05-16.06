
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int result = 0;
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    for (int i = 0; i < counter; i++)
    {
        num = num / 10;
        advance = num - num % 10;
        result = result + ( num - advance);
        
    }
     return result;
}

int sumDigits = SumDigits(number);
Console.WriteLine($"сумма чисел {number} = {sumDigits}");