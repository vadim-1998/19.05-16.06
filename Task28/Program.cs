// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("введено некоректное число");
    return;
}
int factorialNumbers = FactorialNumbers(number);

int FactorialNumbers(int num)
{
    int f = 1;
    for (int i = 1; i <= num; i++)
    {
        checked

        {
            f = f * i;
        }
       
    }
    return f;
}

    Console.WriteLine($" произведение чисел от 1 до {number} = {factorialNumbers}");