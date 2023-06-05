﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;

}

void PrintArray(int[] arr, string sep = ",")
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


int SumOddElement( int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
         sum = sum + arr[i];
         
    }
    return sum;
}

int[] array = CreateArrayRndInt(5, -10, 100);
PrintArray(array);
int sum = SumOddElement(array);
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях -> {sum}");