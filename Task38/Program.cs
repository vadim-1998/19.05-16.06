// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;

}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


double FindMaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}



double[] array = CreateArrayRndDouble(5, 10, 100);
PrintArrayDouble(array);
double max = FindMaxElement(array);
Console.WriteLine($"максимальный элемент массива -> {max}");
double min = FindMinElement(array);
Console.WriteLine($"минимальный элемент массива -> {min}");
string result = string.Format("{0:f2}", max - min);
Console.WriteLine($"разница между максимальным и минимальным элементом массива -> {result}");