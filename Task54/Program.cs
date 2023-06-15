// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,] SortMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = 1; a < matrix.GetLength(1); a++)
            {
                int tmpMax = 0;
                if (matrix[i, a] > matrix[i, a - 1])
                {
                    tmpMax = matrix[i, a - 1];
                    matrix[i, a - 1] = matrix[i, a];
                    matrix[i, a] = tmpMax;
                }
            }

        }
    }
    return matrix;
}





int[,] array2d = CreateMatrixRndInt(4, 4, 10, 0);
PrintMatrix(array2d);
int[,] sortMatrixRows = SortMatrixRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);
