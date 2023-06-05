﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int CountEvenNumber(int[] arr)
{
    int count= 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2 == 0) count += 1;
    }
    return count;
}


int[] array = CreateArrayRndInt(5, 100, 1000);
PrintArray(array);
int count = CountEvenNumber(array);
Console.WriteLine($" количество четных чисел в массиве -> {count}");