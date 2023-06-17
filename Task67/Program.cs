



Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    if( num == 0) return 0;
     return num % 10 + SumDigits(num / 10);


}


int sumDigits = SumDigits(number);
Console.WriteLine($" сумма цифр числа {number} -> {sumDigits}");