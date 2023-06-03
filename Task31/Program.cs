// задайте массив из 12 элементов , заполненный случайными числами из промежутка
// -9 . 9 .Найдите сумму отрицательных и положительных элементов массива






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
      for (int i = 0; i < arr.Length; i++)
   {
    if(i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
    else Console.Write($"{arr[i]}");
   }
}


int[] GetSumPositiveNegativeElem(int [] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
     for (int i = 0; i < arr.Length; i++)               // возвращение из методов
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] {sumPositive, sumNegative};
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)    // решение через два метода
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}



int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");


int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);

Console.WriteLine($"сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"сумма отрицательных элементов = {sumNegativeElem}");

