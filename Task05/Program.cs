// Напмшмте программу, которая на вход принимает одно
// целое число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.

Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int i = -number;
while(i <= number)
{
    Console.WriteLine(i);
    ++i;
}
