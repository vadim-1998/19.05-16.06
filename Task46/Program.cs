// Задайте двумерный массив размером m*n 
// заполненный случайными целыми числами

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
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 100, -100);
PrintMatrix(array2d);