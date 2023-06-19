// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("введите неотрицательное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите неотрицательное число");
int number2 = Convert.ToInt32(Console.ReadLine());

  if (number1 < 0 || number2 < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число");
        return;
    }

int Ackermann(int num1, int num2)
{
    

    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return Ackermann(num1 - 1, 1);
    return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));

}

Console.WriteLine($" вычисления функции Аккермана -> {Ackermann(number1, number2)}");