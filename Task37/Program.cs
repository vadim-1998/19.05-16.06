// найдите произведение пар чисел в одномерном массиве
// парой считаем первый и последний элемент
// результат запишите в новом массиве



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

int [] Multiplyelements(int [] arr)
{
    int newLength = arr.Length / 2;
    if(arr.Length % 2 == 1) newLength += 1;
    int[] newArr = new int[newLength];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if(arr.Length % 2 == 1) newArr[arr.Length / 2] = arr[arr.Length / 2];
    return newArr;
}

int[] array = CreateArrayRndInt(7, 0, 10);
PrintArray(array);
int [] array2 = Multiplyelements(array);
PrintArray(array2);