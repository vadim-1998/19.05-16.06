// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("введите натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)

    {
        Console.WriteLine($"Вы ввели не натуральное число ");
        return;
    }


int SumNaturalNumbers(int num1, int num2)
{
    
    if (num2 == num1) return num1;
    if (num2 < num1) return num2 + SumNaturalNumbers(num1, num2 + 1);
    return num1 + SumNaturalNumbers(num1 + 1, num2);

}


Console.WriteLine($" сумма натуральных элементов в промежутке от {number1} до {number2} -> {SumNaturalNumbers(number1, number2)}");

