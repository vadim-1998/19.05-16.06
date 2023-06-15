// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}


int MinSumRow(int[,] matrix)
{
    int minSum = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) minSum += matrix[i, j];
            else sum += matrix[i, j];
        }

        if (i != 0 && sum < minSum)
        {
            minSum = sum;
            sumRow = i;
        }
    }
    return sumRow;
}



int[,] array2d = CreateMatrixRndInt(3, 3, 10, 0);
PrintMatrix(array2d);
Console.WriteLine();
int minSumRow = MinSumRow(array2d);

Console.WriteLine($"наименьшая сумма элементов -> {MinSumRow(array2d) + 1} строка  ");