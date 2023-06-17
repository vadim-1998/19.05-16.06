
Console.WriteLine("введите натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    else if (num2 < num1)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else
    {
        Console.Write($"{num1} ");
    }

}