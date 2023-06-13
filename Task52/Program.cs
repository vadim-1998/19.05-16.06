// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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



double[] SumAverage(int[,] matrix)
{   
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] sumAverage = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sumAver = 0;
        for (int i = 0; i < rows; i++)
        {
            sumAver += matrix[i, j];
        }
        sumAverage[j] = sumAver / rows;
    }
    return sumAverage;
}



void PrintAverages(double[] matrix, int round = 1)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.WriteLine($"среднее арифметическое элементов столбца {i} -> {Math.Round(matrix[i], round)}");
    }
}


int[,] array2d = CreateMatrixRndInt(3, 3, 10, 1);
PrintMatrix(array2d);
Console.WriteLine();
PrintAverages(SumAverage(array2d));




