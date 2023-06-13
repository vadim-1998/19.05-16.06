﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// , и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());



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


void ReternElement(int[,] matrix)
{
    if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {i} строки и {j} столбца равно {matrix[i - 1, j - 1]}");
    }
}


int[,] array2d = CreateMatrixRndInt(3, 3, 10, 1);
PrintMatrix(array2d);
ReternElement(array2d);
