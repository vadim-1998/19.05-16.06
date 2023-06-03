// Напишите программу замены элементов массива 
// положительные элементы замените на отрицательные и наоборот


int[] CreateArray(int size, int min, int max)
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
    else Console.Write($"{arr[i]} ");
   }
}


void ChangeSight(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}



int [] array = CreateArray(10, -10, 10);
PrintArray(array);
ChangeSight(array);
PrintArray(array);