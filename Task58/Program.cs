// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 4);
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




int Multiplication(int[,] matrix1, int[,] matrix2, int m, int n)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
        sum = sum + matrix1[m, i] * matrix2[i, n];
    }
    return sum;

}

Console.Write("Введите число строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = CreateMatrixRndInt(a, b);
int[,] matrix2 = CreateMatrixRndInt(b, d);
int[,] matrix3 = new int[a, d];

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = Multiplication(matrix1, matrix2, i, j);
    }
}
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Матрица итоговая - перемноженная:");
PrintMatrix(matrix3);